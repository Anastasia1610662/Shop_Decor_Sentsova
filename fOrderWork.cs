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

namespace Shop_Decor_Sentsova
{
    public partial class fOrderWork : Form
    {
        string SQL_CONNECTION_STRING;
        int ROW_COUNT;


        public fOrderWork(string sqlConnection)
        {
            InitializeComponent();
            SQL_CONNECTION_STRING = sqlConnection;
            TableUpdate();
            lbSortingDiscount.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void TableFilter()
        {
            switch (lbSortingDiscount.SelectedIndex)
            {
                case 1:
                    (dgvOrders.DataSource as DataTable).DefaultView.RowFilter = $"[Скидка] < 10";
                    break;
                case 2:
                    (dgvOrders.DataSource as DataTable).DefaultView.RowFilter = $"[Скидка] >=10 and [Скидка] <15";
                    break;
                case 3:
                    (dgvOrders.DataSource as DataTable).DefaultView.RowFilter = $"[Скидка] >= 15";
                    break;
                case 0:
                    (dgvOrders.DataSource as DataTable).DefaultView.RowFilter = $"";
                    break;
            }
            lblCount.Text = $"Количество заказов: {dgvOrders.RowCount} из {ROW_COUNT}";
        }
        
        void TableUpdate()
        {
            SqlCommand logRequst = new SqlCommand();
            logRequst.CommandText = $"SELECT * FROM [ViewOrder]";
            logRequst.Connection = new SqlConnection(SQL_CONNECTION_STRING);
            SqlDataAdapter adapter = new SqlDataAdapter(logRequst);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgvOrders.DataSource = dataSet.Tables[0];
            ROW_COUNT = dgvOrders.RowCount;
            lblCount.Text = $"Количество товаров: {dgvOrders.RowCount} из {ROW_COUNT}";
            lbSortingDiscount.SelectedIndex = 0;
            dgvOrders.Columns[6].Visible = false;
        }

        private void lbSortingPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbSortingPrice.SelectedIndex == 0)
                    dgvOrders.Sort(dgvOrders.Columns[3], ListSortDirection.Ascending);
                else
                    dgvOrders.Sort(dgvOrders.Columns[3], ListSortDirection.Descending);
            }
            catch
            {
                MessageBox.Show("Для начала выберите диапозон по размеру скидок!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbSortingDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableFilter();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connectionString = new SqlConnection(SQL_CONNECTION_STRING))
                {
                    connectionString.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE [dbo].[Order]" +
                        "SET" +
                        "[OrderDeliveryDate] = @OrderDeliveryDate," +
                        "[OrderStatus] = @OrderStatus " +
                        "WHERE [OrderID] = @OrderID";
                    cmd.Connection = connectionString;
                    cmd.Parameters.AddWithValue("@OrderStatus", cboStatus.SelectedItem);
                    cmd.Parameters.AddWithValue("@OrderDeliveryDate", dtpOrder.Value.Date);
                    cmd.Parameters.AddWithValue("@OrderID", dgvOrders.CurrentRow.Cells[6].Value.ToString());
                    cmd.ExecuteNonQuery();
                    connectionString.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошёл сбой!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TableUpdate();
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            lblDiscount.Text = dgvOrders.CurrentRow.Cells[4].Value.ToString() + "%";
        }
    }
}
