using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shop_Decor_Sentsova.fAuth;

namespace Shop_Decor_Sentsova
{
    public partial class fOrders : Form
    {
        User LOCAL_USER;
        string SQL_CONNECTION_STRING;
        List<Order> showOrders;

        public fOrders(List<Order> order, string sqlConnect, User user)
        {
            InitializeComponent();
            SQL_CONNECTION_STRING = sqlConnect;
            showOrders = order;
            LOCAL_USER = user;
            if (LOCAL_USER.UserRole == 4)
                lblFIO.Text = "Вы находитесь в гостевом режиме!";
            else
                lblFIO.Text = $"Учетная запись: \n{LOCAL_USER.UserSurname} {LOCAL_USER.UserName} {LOCAL_USER.UserPatronymic}!";
            LoadPickUpPoints();
            LoadDataToListBox();
        }

        private void LoadDataToListBox()
        {
            try
            {
                lstOrders.DataSource = showOrders;
                GetCost();
                if (lstOrders.Items.Count == 0)
                    btnMakeOrder.Enabled = false;
                else
                    btnMakeOrder.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить товары!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GetCost()
        {
            decimal finalSumWithDiscount = 0;
            int finalSumDiscountAmount = 0;
            foreach (Order order in showOrders)
            {
                finalSumWithDiscount += Convert.ToDecimal(order.ProductCost);
                finalSumDiscountAmount += Convert.ToInt32(order.ProductCostWithDiscount);
            }
            lblCostWithDiscount.Text = $"{finalSumWithDiscount}";
            lblCostDiscounts.Text = $"{finalSumDiscountAmount}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPickUpPoints()
        {
            try
            {
                using (SqlConnection connectionString = new SqlConnection(SQL_CONNECTION_STRING))
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT ItemID, CONCAT(" +
                        "[ItemIndex]," +
                        "[ItemCity]," +
                        "[ItemStreet]" +
                        ") as [Пункт выдачи]  " +
                        "FROM [Supershop].[dbo].[PickUp_Point]";
                    cmd.Connection = connectionString;
                    connectionString.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        adapter.Fill(dt);
                    cboPickUpPoints.DataSource = dt;
                    cboPickUpPoints.DisplayMember = "Пункт выдачи";
                    cboPickUpPoints.ValueMember = "ItemID";
                    connectionString.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            fTicket fTicket = new fTicket(showOrders);
            fTicket.ShowDialog();
            this.Show();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            var count =
                    from order in showOrders
                    group order by order.ProductArticleNumber into articles
                    select new
                    {
                        ProductArticleNumber = articles.Key,
                        Count = articles.Count(),
                    };

            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            int id;
            int orderCode;
            if (cboPickUpPoints.SelectedValue != null)
            {
                int pickUpPoint = (int)cboPickUpPoints.SelectedValue;
                Order.OrderPickUpPoint = cboPickUpPoints.Text;
                Order.OrderDate = today;

                if (MessageBox.Show("Вы точно уверены в своём выборе? ", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connectionString = new SqlConnection(SQL_CONNECTION_STRING))
                    {
                        connectionString.Open();
                        foreach (var items in count)
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = "SELECT MAX([OrderID]) FROM [Supershop].[dbo].[Order]";
                            cmd.Connection = connectionString;
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            int orderID = (int)dt.Rows[0].ItemArray[0] + 1;

                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.CommandText = "SELECT MAX([Code]) FROM [Supershop].[dbo].[Order]";
                            cmd1.Connection = connectionString;
                            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                            DataTable dt1 = new DataTable();
                            adapter1.Fill(dt1);
                            orderCode = (int)dt.Rows[0].ItemArray[0];
                            Order.OrderCode = (orderCode + 1).ToString();

                            SqlCommand cmd2 = new SqlCommand();
                            cmd2.CommandText = "INSERT INTO [dbo].[Order]\r\n           " +
                                "([OrderID]," +
                                "[OrderDate]," +
                                "[OrderDeliveryDate]," +
                                "[OrderPickupPoint]," +
                                "[UserID]," +
                                "[Code]," +
                                "[OrderStatus]) " +
                                "VALUES " +
                                "(@OrderId," +
                                "@OrderDate," +
                                "@OrderDeliveryDate," +
                                "@OrderPickupPoint," +
                                "@OrderClient," +
                                "@OrderCode," +
                                "'Новый')";
                            cmd2.Connection = connectionString;
                            cmd2.Parameters.AddWithValue("@OrderDate", today);
                            if (items.Count < 3)
                                cmd2.Parameters.AddWithValue("@OrderDeliveryDate", today.AddDays(6));
                            else
                                cmd2.Parameters.AddWithValue("@OrderDeliveryDate", today.AddDays(3));
                            cmd2.Parameters.AddWithValue("@OrderPickupPoint", pickUpPoint);
                            cmd2.Parameters.AddWithValue("@OrderCost", Convert.ToDecimal(lblCostWithDiscount.Text));
                            cmd2.Parameters.AddWithValue("@OrderDiscountAmount", Convert.ToInt32(lblCostDiscounts.Text));
                            cmd2.Parameters.AddWithValue("@OrderCode", Convert.ToInt32(Order.OrderCode));
                            cmd2.Parameters.AddWithValue("@OrderId", orderID);
                            if (LOCAL_USER.UserRole == 4)
                                cmd2.Parameters.AddWithValue("@OrderClient", DBNull.Value);
                            else
                                cmd2.Parameters.AddWithValue("@OrderClient", LOCAL_USER.UserID);
                            cmd2.ExecuteNonQuery();

                            SqlCommand cmd3 = new SqlCommand();
                            cmd3.CommandText = "INSERT INTO [dbo].[OrderProduct] " +
                                "([OrderPID]," +
                                "[ProductArticleNumbe]," +
                                "[Quantity]) " +
                                "VALUES " +
                                "(@OrderId," +
                                "@ProductArticleNumber," +
                                "@OrderQuantity)";
                            cmd3.Connection = connectionString;
                            cmd3.Parameters.AddWithValue("@OrderId", orderID);
                            cmd3.Parameters.AddWithValue("@ProductArticleNumber", items.ProductArticleNumber);
                            cmd3.Parameters.AddWithValue("@OrderQuantity", items.Count);
                            cmd3.ExecuteNonQuery();
                        }
                        connectionString.Close();
                    }
                    MessageBox.Show($"Ваш заказ принят!\nМожете получить свой талон.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTicket.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Для начала выберите пункт выдачи!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void удалитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstOrders.Items.Count != -1)
            {
                int selectedIndex = lstOrders.SelectedIndex;
                showOrders.RemoveAt(selectedIndex);
            }
            lstOrders.DataSource = null;
            LoadDataToListBox();
        }
    }
}
