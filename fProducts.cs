using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Shop_Decor_Sentsova.fAuth;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shop_Decor_Sentsova
{
    public partial class fProducts : Form
    {
        User LOCAL_USER;
        string SQL_CONNECTION_STRING;
        int ROW_COUNT;
        List<Order> showOrders;

        public fProducts(User user, string sqlConn)
        {
            InitializeComponent();
            LOCAL_USER = user;
            SQL_CONNECTION_STRING = sqlConn;
            ShowFunctionality();
            TableUpdate();


        }

        void TableUpdate()
        {
            SqlCommand logRequst = new SqlCommand();
            logRequst.CommandText = $"SELECT * FROM Prod";
            logRequst.Connection = new SqlConnection(SQL_CONNECTION_STRING);
            SqlDataAdapter adapter = new SqlDataAdapter(logRequst);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgvProducts.DataSource = dataSet.Tables[0];
            dgvProducts.Columns[10].Visible = false;
            ROW_COUNT = dgvProducts.RowCount;
            lblCount.Text = $"Количество товаров: {dgvProducts.RowCount} из {ROW_COUNT}";
            lbSortingDiscount.SelectedIndex = 0;
        }

        private void ShowFunctionality()
        {
            //Отображение данных и возможностей в зависимости от роли пользователя.
            switch (LOCAL_USER.UserRole)
            {
                case 1:
                    lblFIO.Text = $"Добро пожаловать,\n{LOCAL_USER.UserSurname} {LOCAL_USER.UserName} {LOCAL_USER.UserPatronymic}!";
                    break;
                case 2:
                    lblFIO.Text = $"Добро пожаловать,\n{LOCAL_USER.UserSurname} {LOCAL_USER.UserName} {LOCAL_USER.UserPatronymic}!";
                    btnWork.Visible = true;
                    break;
                case 3:
                    lblFIO.Text = $"Добро пожаловать,\n{LOCAL_USER.UserSurname} {LOCAL_USER.UserName} {LOCAL_USER.UserPatronymic}!";
                    btnWork.Visible = true;
                    удалитьТоварToolStripMenuItem.Visible = true;
                    добавитьТоварToolStripMenuItem.Visible = true;
                    break;
                case 4:
                    lblFIO.Text = "Добро пожаловать, Гость!";
                    break;
            }
        }

        private void ShowProducts()
        {
            using (SqlConnection connectionString = new SqlConnection(SQL_CONNECTION_STRING))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connectionString;
                    connectionString.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    dgvProducts.DataSource = dt;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошёл сбой!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connectionString.Close();
                lblCount.Text = $"Количество товаров: {dgvProducts.RowCount} из {dgvProducts.RowCount}";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            TableFilter();
        }

        private void lbSortingDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableFilter();
        }

        void TableFilter()
        {
            switch (lbSortingDiscount.SelectedIndex)
            {
                case 1:
                    (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = $"[Сумма скидки] < 10 and [Название продукта] LIKE '%{tbSearchProduct.Text}%'";
                    break;
                case 2:
                    (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = $"[Сумма скидки] >=10 and [Сумма скидки] <15 and [Название продукта] LIKE '%{tbSearchProduct.Text}%'";
                    break;
                case 3:
                    (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = $"[Сумма скидки] >= 15 and [Название продукта] LIKE '%{tbSearchProduct.Text}%'";
                    break;
                case 0:
                    (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = $"[Название продукта] LIKE '%{tbSearchProduct.Text}%'";
                    break;
            }
            lblCount.Text = $"Количество товаров: {dgvProducts.RowCount} из {ROW_COUNT}";
            
        }

        private void lbSortingPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Сортировка товаров (по возрастанию и убыванию) по стоимости.
                if (lbSortingPrice.SelectedIndex == 0)
                {
                    dgvProducts.Sort(dgvProducts.Columns[9], ListSortDirection.Ascending);
                }
                else
                {
                    dgvProducts.Sort(dgvProducts.Columns[9], ListSortDirection.Descending);
                }
            }
            catch
            {
                MessageBox.Show("Для начала выберите диапозон по размеру скидок!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void добавитьКЗакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string quantityInStock = dgvProducts.CurrentRow.Cells[9].Value.ToString();
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string productPhoto = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            string photoPath = Path.Combine(projectDirectory, $"Resources\\Images\\{productPhoto}.jpg");
            if (quantityInStock != "0")
            {
                btnShowOrder.Visible = true;
                try
                {
                    if (!File.Exists(photoPath))
                    {
                        photoPath = Path.Combine(projectDirectory, $"Resources\\Images\\picture.png");
                    }

                    Order order = new Order
                    {
                        ProductName = dgvProducts.CurrentRow.Cells[0].Value.ToString(),
                        ProductCategory = dgvProducts.CurrentRow.Cells[1].Value.ToString(),
                        ProductDescription = dgvProducts.CurrentRow.Cells[2].Value.ToString(),
                        ProductManufacturer = dgvProducts.CurrentRow.Cells[5].Value.ToString(),
                        ProductDiscountAmount = dgvProducts.CurrentRow.Cells[7].Value.ToString(),
                        ProductCostWithDiscount = dgvProducts.CurrentRow.Cells[8].Value.ToString(),
                        ProductCost = dgvProducts.CurrentRow.Cells[9].Value.ToString(),
                        ProductArticleNumber = dgvProducts.CurrentRow.Cells[10].Value.ToString(),
                        ProductPhoto = photoPath
                    };
                    if (showOrders == null)
                    {
                        showOrders = new List<Order>();
                    }
                    showOrders.Add(order);
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Произошёл сбой!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Товара нет в наличии!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            lblProductName.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            lblProductDescription.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            lblProductManufacturer.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            lblCost.Text = dgvProducts.CurrentRow.Cells[9].Value.ToString();
            lblDiscount.Text = dgvProducts.CurrentRow.Cells[8].Value.ToString()+"%";
            lblCostWithDiscount.Text = ((int)dgvProducts.CurrentRow.Cells[9].Value*(100-(int)dgvProducts.CurrentRow.Cells[8].Value)/100).ToString();

            if (lblCost.Text != lblCostWithDiscount.Text)
                lblCost.Font = new Font(lblCost.Font, FontStyle.Strikeout);
            else
                lblCost.Font = new Font(lblCost.Font, FontStyle.Regular);
            if (dgvProducts.CurrentRow != null)
            {
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string productPhoto = dgvProducts.CurrentRow.Cells[10].Value.ToString();
                string photoPath = Path.Combine(projectDirectory, $"Resources\\Images\\{productPhoto}.jpg");
                if (!File.Exists(photoPath))
                {
                    photoPath = Path.Combine(projectDirectory, $"Resources\\Images\\picture.png");
                }
                picProduct.Image = Image.FromFile(photoPath);
            }
            if (Convert.ToInt16(lblDiscount.Text.Replace("%","")) >= 15)
                lblDiscount.BackColor = Color.Chartreuse;
            else
                lblDiscount.BackColor = Color.FromArgb(255, 204, 153);
        }

        private void удалитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить данный товар? ", "Сообщение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connectionString = new SqlConnection(SQL_CONNECTION_STRING))
                    {
                        connectionString.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "DELETE FROM [dbo].[Products] WHERE [ProductArticleNumber]=@ProductArticleNumber";
                        cmd.Connection = connectionString;
                        cmd.Parameters.AddWithValue("@ProductArticleNumber", dgvProducts.CurrentRow.Cells[10].Value.ToString());
                        cmd.ExecuteNonQuery();
                        connectionString.Close();

                    }
                    MessageBox.Show($"Товар был успешно удалён!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TableUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошёл сбой!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddProduct fAddProduct = new fAddProduct(SQL_CONNECTION_STRING);
            fAddProduct.ShowDialog(this);
            TableUpdate();
        }

        private void dgvProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
                if (Convert.ToInt32(row.Cells[8].Value) >= 15)
                    row.DefaultCellStyle.BackColor = Color.Chartreuse;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            fOrderWork fOrderWork = new fOrderWork();
            this.Hide();
            fOrderWork.ShowDialog();
            this.Show();
        }

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            using (var frm = new fOrders(showOrders))
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            if (showOrders.Count == 0)
            {
                btnShowOrder.Visible = false;
            }
        }
    }
}
