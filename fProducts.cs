using Microsoft.SqlServer.Server;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shop_Decor_Sentsova
{
    public partial class fProducts : Form
    {
        User LOCAL_USER;
        string SQL_CONNECTION_STRING;

        public fProducts(User user, string sqlConn)
        {
            InitializeComponent();
            LOCAL_USER = user;
            MessageBox.Show(LOCAL_USER.ToString());
            SQL_CONNECTION_STRING = sqlConn;
            ShowFunctionality();
            SqlCommand logRequst = new SqlCommand();
            logRequst.CommandText = $"SELECT * FROM Prod";
            logRequst.Connection = new SqlConnection(SQL_CONNECTION_STRING);
            SqlDataAdapter adapter = new SqlDataAdapter(logRequst);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgvProducts.DataSource = dataSet.Tables[0];
            dgvProducts.Columns[10].Visible = false;
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
                    int selectedDiscount = lbSortingDiscount.SelectedIndex;
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connectionString;
                    connectionString.Open();

                    switch (selectedDiscount)
                    {
                        //Фильтрация товаров по скидке из пункта "Все диапозоны".
                        case 0:
                            cmd.CommandText = "GetAllDiscounts";
                            break;
                        //Фильтрация товаров по скидке из пункта "0-9,99%".
                        case 1:
                            cmd.CommandText = "GetDiscountBeforeNine";
                            break;
                        //Фильтрация товаров по скидке из пункта "10 - 14,99%".
                        case 2:
                            cmd.CommandText = "GetDiscountBeforeFourteen";
                            break;
                        //Фильтрация товаров по скидке из пункта "15 % и более".
                        case 3:
                            cmd.CommandText = "GetDiscountMoreFifteen";
                            break;
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    dgvProducts.DataSource = dt;

                    //Изменение цвета полей в DataGridView в случае действ. скидки > 15%
                    foreach (DataGridViewRow row in dgvProducts.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[8].Value) > 15)
                        {
                            row.DefaultCellStyle.BackColor = Color.Chartreuse;
                        }
                    }
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
            (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = $"[Название продукта] LIKE '%{tbSearchProduct.Text}%'";
        }

        private void lbSortingDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbSortingDiscount.SelectedIndex)
            {
                case 1:
                    (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = @"[Сумма скидки] < 10";
                    break;
                case 2:
                    (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = $"[Сумма скидки] >=10 and [Сумма скидки] <15";
                    break;
                case 3:
                    (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = $"[Сумма скидки] >= 15";
                    break;
                case 0:
                    (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
            }
        }
    }
}
