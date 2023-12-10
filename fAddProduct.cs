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
        string SQL_CONNECTION_STRING;

        public fAddProduct(string sqlConnect)
        {
            InitializeComponent();
            SQL_CONNECTION_STRING = sqlConnect;
            cbUnit.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbArticle.Text) && String.IsNullOrEmpty(tbCategory.Text) && String.IsNullOrEmpty(tbCost.Text) &&
                String.IsNullOrEmpty(tbDescription.Text) && String.IsNullOrEmpty(tbDiscountAmount.Text) && String.IsNullOrEmpty(tbManufacturer.Text)
                && String.IsNullOrEmpty(tbMaxDiscount.Text) && String.IsNullOrEmpty(tbName.Text) && String.IsNullOrEmpty(tbQuantity.Text)
                && String.IsNullOrEmpty(tbSupplier.Text) && (openFileDialog1.FileName != null))
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
                        cmd.Parameters.AddWithValue("@ProductArticleNumber", tbArticle.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductName", tbName.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductUnitOfMeasurement", cbUnit.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductCost", Convert.ToDecimal(tbCost.Text.ToString()));
                        cmd.Parameters.AddWithValue("@ProductMaxDiscountAmount", Convert.ToInt32(tbMaxDiscount.Text.ToString()));
                        cmd.Parameters.AddWithValue("@ProductManufacturer", tbManufacturer.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductProvider", tbSupplier.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductCategory", tbCategory.Text.ToString());
                        cmd.Parameters.AddWithValue("@ProductEffectiveDiscount", Convert.ToInt32(tbDiscountAmount.Text.ToString()));
                        cmd.Parameters.AddWithValue("@ProductQuantityInStock", Convert.ToInt32(tbQuantity.Text.ToString()));
                        cmd.Parameters.AddWithValue("@ProductDescription", tbDescription.Text.ToString());
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошёл сбой!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCostWithDiscount_Click(object sender, EventArgs e)
        {
            int cost = Convert.ToInt32(tbCost.Text.ToString());
            int discount = Convert.ToInt32(tbDiscountAmount.Text.ToString());
            tbWithDiscount.Text = (cost - cost * discount / 100).ToString();
        }
    }
}
