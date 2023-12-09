namespace Shop_Decor_Sentsova
{
    partial class fAuth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAuth));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCaptcha_Check = new System.Windows.Forms.Button();
            this.btnCaptcha_Reset = new System.Windows.Forms.Button();
            this.tbCaptcha = new System.Windows.Forms.TextBox();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.picCaptcha = new System.Windows.Forms.PictureBox();
            this.btnGuest = new System.Windows.Forms.Button();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).BeginInit();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCaptcha_Check);
            this.panel1.Controls.Add(this.btnCaptcha_Reset);
            this.panel1.Controls.Add(this.tbCaptcha);
            this.panel1.Controls.Add(this.lblCaptcha);
            this.panel1.Controls.Add(this.btnAuth);
            this.panel1.Controls.Add(this.picCaptcha);
            this.panel1.Controls.Add(this.btnGuest);
            this.panel1.Controls.Add(this.cbPassword);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.tbLogin);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.pnlUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 622);
            this.panel1.TabIndex = 0;
            // 
            // btnCaptcha_Check
            // 
            this.btnCaptcha_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnCaptcha_Check.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCaptcha_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptcha_Check.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnCaptcha_Check.Location = new System.Drawing.Point(0, 470);
            this.btnCaptcha_Check.Name = "btnCaptcha_Check";
            this.btnCaptcha_Check.Size = new System.Drawing.Size(311, 38);
            this.btnCaptcha_Check.TabIndex = 28;
            this.btnCaptcha_Check.Text = "Проверить капчу";
            this.btnCaptcha_Check.UseVisualStyleBackColor = false;
            this.btnCaptcha_Check.Visible = false;
            this.btnCaptcha_Check.Click += new System.EventHandler(this.btnCaptcha_Check_Click);
            // 
            // btnCaptcha_Reset
            // 
            this.btnCaptcha_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnCaptcha_Reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCaptcha_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptcha_Reset.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnCaptcha_Reset.Location = new System.Drawing.Point(0, 508);
            this.btnCaptcha_Reset.Name = "btnCaptcha_Reset";
            this.btnCaptcha_Reset.Size = new System.Drawing.Size(311, 38);
            this.btnCaptcha_Reset.TabIndex = 27;
            this.btnCaptcha_Reset.Text = "Сбросить капчу";
            this.btnCaptcha_Reset.UseVisualStyleBackColor = false;
            this.btnCaptcha_Reset.Visible = false;
            this.btnCaptcha_Reset.Click += new System.EventHandler(this.btnCaptcha_Reset_Click);
            // 
            // tbCaptcha
            // 
            this.tbCaptcha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCaptcha.Location = new System.Drawing.Point(49, 413);
            this.tbCaptcha.MaxLength = 20;
            this.tbCaptcha.Name = "tbCaptcha";
            this.tbCaptcha.Size = new System.Drawing.Size(208, 30);
            this.tbCaptcha.TabIndex = 26;
            this.tbCaptcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCaptcha.Visible = false;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblCaptcha.Location = new System.Drawing.Point(88, 293);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(125, 23);
            this.lblCaptcha.TabIndex = 25;
            this.lblCaptcha.Text = "Введите капчу";
            this.lblCaptcha.Visible = false;
            // 
            // btnAuth
            // 
            this.btnAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnAuth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnAuth.Location = new System.Drawing.Point(0, 546);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(311, 38);
            this.btnAuth.TabIndex = 23;
            this.btnAuth.Text = "Войти";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // picCaptcha
            // 
            this.picCaptcha.Location = new System.Drawing.Point(49, 319);
            this.picCaptcha.Name = "picCaptcha";
            this.picCaptcha.Size = new System.Drawing.Size(208, 88);
            this.picCaptcha.TabIndex = 22;
            this.picCaptcha.TabStop = false;
            this.picCaptcha.Visible = false;
            // 
            // btnGuest
            // 
            this.btnGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnGuest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnGuest.Location = new System.Drawing.Point(0, 584);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(311, 38);
            this.btnGuest.TabIndex = 24;
            this.btnGuest.Text = "Войти как гость";
            this.btnGuest.UseVisualStyleBackColor = false;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPassword.Location = new System.Drawing.Point(73, 227);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(159, 27);
            this.cbPassword.TabIndex = 20;
            this.cbPassword.Text = "Показать пароль";
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(49, 189);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(208, 30);
            this.tbPassword.TabIndex = 19;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(117, 163);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 23);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(49, 129);
            this.tbLogin.MaxLength = 20;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(208, 30);
            this.tbLogin.TabIndex = 17;
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(123, 103);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(58, 23);
            this.lblLogin.TabIndex = 16;
            this.lblLogin.Text = "Логин";
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlUp.Controls.Add(this.picLogo);
            this.pnlUp.Controls.Add(this.lblShopName);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(311, 100);
            this.pnlUp.TabIndex = 15;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(179, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(127, 94);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShopName.Location = new System.Drawing.Point(12, 36);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(161, 23);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "ООО «Украшение»";
            // 
            // fAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 622);
            this.Controls.Add(this.panel1);
            this.Name = "fAuth";
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).EndInit();
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCaptcha_Check;
        private System.Windows.Forms.Button btnCaptcha_Reset;
        private System.Windows.Forms.TextBox tbCaptcha;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.PictureBox picCaptcha;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.CheckBox cbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblShopName;
    }
}

