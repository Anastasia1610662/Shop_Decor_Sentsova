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
    public partial class fAddProduct : Form
    {
        User LOCAL_USER;
        string SQL_CONNECTION_STRING;
        int ROW_COUNT;
        List<Order> showOrders;

        public fAddProduct(string sqlConnect)
        {
            InitializeComponent();
            SQL_CONNECTION_STRING = sqlConnect;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtArticle.Text) && String.IsNullOrEmpty(txtCategory.Text) && String.IsNullOrEmpty(txtCost.Text) &&
                String.IsNullOrEmpty(txtDescription.Text) && String.IsNullOrEmpty(txtDiscountAmount.Text) && String.IsNullOrEmpty(txtManufacturer.Text)
                && String.IsNullOrEmpty(txtMaxDiscount.Text) && String.IsNullOrEmpty(txtName.Text) && String.IsNullOrEmpty(txtQuantity.Text)
                && String.IsNullOrEmpty(txtSupplier.Text) && String.IsNullOrEmpty(txtUnit.Text) && (openFileDialog1.FileName != null))
            {
                MessageBox.Show("Заполните все поля и выберите изображение!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (SqlConnection connectionString = new SqlConnection(SQL_CONNECTION_STRING))
                    {
                        connectionString.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "INSERT INTO [dbo].[Products]" +
                            "([ProductArticleNumber]," +
                            "[ProductName]," +
                            "[Quantity]," +
                            "[ProductCost]," +
                            "[ProductDiscountAmount]," +
                            "[ProductManufacturer]," +
                            "[ProductProvider]," +
                            "[ProductCategory]," +
                            "[ProductEffectiveDiscount]," +
                            "[ProductQuantityInStock]," +
                            "[ProductDescription1]," +
                            "[ProductPhoto])" +
                            "VALUES" +
                            "(@ProductArticleNumber," +
                            "@ProductName," +
                            "@ProductUnitOfMeasurement," +
                            "@ProductCost," +
                            "@ProductMaxDiscountAmount," +
                            "@ProductManufacturer," +
                            "@ProductProvider," +
                            "@ProductCategory," +
                            "@ProductEffectiveDiscount," +
                            "@ProductQuantityInStock," +
                            "@ProductDescription," +
                            "@ProductPhoto)";
                        cmd.Connection = connectionString;
                        cmd.Parameters.AddWithValue("@ProductArticleNumber", txtArticle.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductName", txtName.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductUnitOfMeasurement", txtUnit.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductCost", Convert.ToDecimal(txtCost.Text.ToString()));
                        cmd.Parameters.AddWithValue("@ProductMaxDiscountAmount", Convert.ToInt32(txtMaxDiscount.Text.ToString()));
                        cmd.Parameters.AddWithValue("@ProductManufacturer", txtManufacturer.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductProvider", txtSupplier.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductCategory", txtCategory.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductEffectiveDiscount", Convert.ToInt32(txtDiscountAmount.Text.ToString()));
                        cmd.Parameters.AddWithValue("@ProductQuantityInStock", Convert.ToInt32(txtQuantity.Text.ToString()));
                        cmd.Parameters.AddWithValue("@ProductDescription", txtDescription.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductPhoto", openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\')).Replace("\\",""));
                        cmd.ExecuteNonQuery();
                        connectionString.Close();

                    }
                    MessageBox.Show($"Товар был успешно добавление!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошёл сбой!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picProduct.Image = Image.FromFile(openFileDialog1.FileName);
                    lblPath.Text = openFileDialog1.SafeFileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошёл сбой!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
