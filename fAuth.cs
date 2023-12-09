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
    public partial class fAuth : Form
    {
        string WORD = "";
        int INCORRECT_ANSW = 0;
        public User user;
        string DEFAULT_LOGIN = "QWERTY";
        string DEFAULT_PASSWORD = "QWERTY123";
        public string SQL_CONNECTION_STRING = @"Data Source=SEGAWINDB\SEGAMSSQL;Initial Catalog=Supershop;Password=P@ssw0rd; User ID=SE;";

        public struct User
        {
            public int UserID;
            public string UserSurname;
            public string UserName;
            public string UserPatronymic;
            public int UserRole;
        }

        public fAuth()
        {
            InitializeComponent();
            tbLogin.Text = DEFAULT_LOGIN;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.Text = DEFAULT_PASSWORD;
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;

            if (String.IsNullOrEmpty(tbLogin.Text) || String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connectionString = new SqlConnection(SQL_CONNECTION_STRING))
                {
                    connectionString.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "Aut"
                    };
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Connection = connectionString;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        if (reader.HasRows)
                        {
                            user.UserID = reader.GetInt32(0);
                            user.UserSurname = reader.GetString(1);
                            user.UserName = reader.GetString(2);
                            user.UserPatronymic = reader.GetString(3);
                            user.UserRole = reader.GetInt32(6);
                            ShowProducts();
                        }
                        else
                        {
                            MessageBox.Show($"Неверное имя пользователя или пароль!",
                                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            INCORRECT_ANSW++;
                            if (INCORRECT_ANSW > 0)
                            {
                                MessageBox.Show($"К сожалению, настало время капчи.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                WORD = "";
                                LoadCaptcha();
                                tbCaptcha.Visible = true;
                                btnCaptcha_Check.Visible = true;
                                btnCaptcha_Reset.Visible = true;
                                btnAuth.Enabled = false;
                            }
                        }
                        reader.Close();
                    }
                    connectionString.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            user.UserRole = 4;
            ShowProducts();
        }

        private void btnCaptcha_Reset_Click(object sender, EventArgs e)
        {
            WORD = "";
            LoadCaptcha();
        }

        private async void btnCaptcha_Check_Click(object sender, EventArgs e)
        {
            if (tbCaptcha.Text == WORD.ToString())
            {
                MessageBox.Show($"Капча прошла проверку!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAuth.Enabled = true;
            }
            else
            {
                MessageBox.Show($"Капча не прошла проверку!\nБлокировка возможности входа на 10 секунд.\n" +
                    $"Пожалуйста, подождите!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                btnCaptcha_Check.Enabled = false;
                btnAuth.Enabled = false;
                await Task.Delay(10000);
                btnAuth.Enabled = true;
                btnCaptcha_Check.Enabled = true;
            }
        }

        private void LoadCaptcha()
        {
            //Генерация капчи.
            picCaptcha.Visible = true;
            Random random = new Random();

            string chars = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 6; ++i)
                WORD += chars[random.Next(chars.Length)];
            var ing = new Bitmap(this.picCaptcha.Width, this.picCaptcha.Height);
            var font = new Font("Arial", 30, FontStyle.Italic, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(ing);
            graphics.Clear(Color.White);
            graphics.DrawString(WORD.ToString(), font, Brushes.DarkGray, new Point(15, 35));
            graphics.DrawLine(Pens.Red, new Point(0, 0), new Point(Width - 5, Height - 1));
            graphics.DrawLine(Pens.Blue, new Point(0, 100), new Point(150, 0));
            graphics.DrawLine(Pens.Black, new Point(40, 1000), new Point(70, 0));
            picCaptcha.Image = ing;
        }

        private void ShowProducts()
        {
            fProducts product = new fProducts(user,SQL_CONNECTION_STRING);
            this.Hide();
            product.ShowDialog(this);
            this.Show();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
                tbPassword.UseSystemPasswordChar = false;
            else
                tbPassword.UseSystemPasswordChar = true;
        }
    }
}
