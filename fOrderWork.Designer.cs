namespace Shop_Decor_Sentsova
{
    partial class fOrderWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOrderWork));
            this.pnlUp = new System.Windows.Forms.Panel();
            this.lbSortingDiscount = new System.Windows.Forms.ComboBox();
            this.lblSortingDiscount = new System.Windows.Forms.Label();
            this.lbSortingPrice = new System.Windows.Forms.ComboBox();
            this.lblSortingPrice = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDiscount = new System.Windows.Forms.Panel();
            this.pnlProductDescription = new System.Windows.Forms.Panel();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlDown.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDiscount.SuspendLayout();
            this.pnlProductDescription.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlUp.Controls.Add(this.lblCount);
            this.pnlUp.Controls.Add(this.lbSortingDiscount);
            this.pnlUp.Controls.Add(this.lblSortingDiscount);
            this.pnlUp.Controls.Add(this.lbSortingPrice);
            this.pnlUp.Controls.Add(this.lblSortingPrice);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUp.Location = new System.Drawing.Point(3, 3);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1250, 135);
            this.pnlUp.TabIndex = 4;
            // 
            // lbSortingDiscount
            // 
            this.lbSortingDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbSortingDiscount.FormattingEnabled = true;
            this.lbSortingDiscount.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-10%",
            "11-14%",
            "15% и более "});
            this.lbSortingDiscount.Location = new System.Drawing.Point(415, 34);
            this.lbSortingDiscount.Name = "lbSortingDiscount";
            this.lbSortingDiscount.Size = new System.Drawing.Size(232, 31);
            this.lbSortingDiscount.TabIndex = 6;
            this.lbSortingDiscount.SelectedIndexChanged += new System.EventHandler(this.lbSortingDiscount_SelectedIndexChanged);
            // 
            // lblSortingDiscount
            // 
            this.lblSortingDiscount.AutoSize = true;
            this.lblSortingDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblSortingDiscount.Location = new System.Drawing.Point(379, 8);
            this.lblSortingDiscount.Name = "lblSortingDiscount";
            this.lblSortingDiscount.Size = new System.Drawing.Size(301, 23);
            this.lblSortingDiscount.TabIndex = 5;
            this.lblSortingDiscount.Text = "Отфильтровать по суммарной скидке";
            // 
            // lbSortingPrice
            // 
            this.lbSortingPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbSortingPrice.FormattingEnabled = true;
            this.lbSortingPrice.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.lbSortingPrice.Location = new System.Drawing.Point(57, 34);
            this.lbSortingPrice.Name = "lbSortingPrice";
            this.lbSortingPrice.Size = new System.Drawing.Size(232, 31);
            this.lbSortingPrice.TabIndex = 3;
            this.lbSortingPrice.SelectedIndexChanged += new System.EventHandler(this.lbSortingPrice_SelectedIndexChanged);
            // 
            // lblSortingPrice
            // 
            this.lblSortingPrice.AutoSize = true;
            this.lblSortingPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblSortingPrice.Location = new System.Drawing.Point(8, 8);
            this.lblSortingPrice.Name = "lblSortingPrice";
            this.lblSortingPrice.Size = new System.Drawing.Size(327, 23);
            this.lblSortingPrice.TabIndex = 2;
            this.lblSortingPrice.Text = "Отсортировать по суммарной стоимости";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrders.Size = new System.Drawing.Size(1250, 383);
            this.dgvOrders.TabIndex = 6;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlDown.Controls.Add(this.btnUpdate);
            this.pnlDown.Controls.Add(this.btnClose);
            this.pnlDown.Controls.Add(this.pnlLogo);
            this.pnlDown.Controls.Add(this.pnlDiscount);
            this.pnlDown.Controls.Add(this.pnlProductDescription);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDown.Location = new System.Drawing.Point(3, 533);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(1250, 135);
            this.pnlDown.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnClose.Location = new System.Drawing.Point(1151, 65);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 62);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(3, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(177, 129);
            this.pnlLogo.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(167, 119);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // pnlDiscount
            // 
            this.pnlDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDiscount.Controls.Add(this.lblOut);
            this.pnlDiscount.Controls.Add(this.lblDiscount);
            this.pnlDiscount.Location = new System.Drawing.Point(968, 3);
            this.pnlDiscount.Name = "pnlDiscount";
            this.pnlDiscount.Size = new System.Drawing.Size(284, 56);
            this.pnlDiscount.TabIndex = 12;
            // 
            // pnlProductDescription
            // 
            this.pnlProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProductDescription.Controls.Add(this.dtpOrder);
            this.pnlProductDescription.Controls.Add(this.cboStatus);
            this.pnlProductDescription.Controls.Add(this.lblProductDescription);
            this.pnlProductDescription.Controls.Add(this.lblProductName);
            this.pnlProductDescription.Location = new System.Drawing.Point(186, 3);
            this.pnlProductDescription.Name = "pnlProductDescription";
            this.pnlProductDescription.Size = new System.Drawing.Size(776, 129);
            this.pnlProductDescription.TabIndex = 1;
            // 
            // lblOut
            // 
            this.lblOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOut.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblOut.Location = new System.Drawing.Point(3, 0);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(274, 24);
            this.lblOut.TabIndex = 8;
            this.lblOut.Text = "Размер скидки: ";
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblDiscount.Location = new System.Drawing.Point(3, 24);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(274, 24);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "Скидка";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(968, 65);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 62);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpOrder
            // 
            this.dtpOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.dtpOrder.Location = new System.Drawing.Point(392, 61);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(200, 30);
            this.dtpOrder.TabIndex = 20;
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Новый",
            "Завершен"});
            this.cboStatus.Location = new System.Drawing.Point(216, 61);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(139, 31);
            this.cboStatus.TabIndex = 17;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductDescription.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblProductDescription.Location = new System.Drawing.Point(400, 32);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(191, 25);
            this.lblProductDescription.TabIndex = 19;
            this.lblProductDescription.Text = "Дата доставки";
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductName.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblProductName.Location = new System.Drawing.Point(180, 33);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(217, 25);
            this.lblProductName.TabIndex = 18;
            this.lblProductName.Text = "Статус заказа";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCount.Location = new System.Drawing.Point(53, 98);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(169, 23);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Количество заказов: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlDown, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlUp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.60377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.39622F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1256, 671);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOrders);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 383);
            this.panel2.TabIndex = 5;
            // 
            // fOrderWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fOrderWork";
            this.Text = "Работа с заказами";
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlDown.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDiscount.ResumeLayout(false);
            this.pnlProductDescription.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.ComboBox lbSortingDiscount;
        private System.Windows.Forms.Label lblSortingDiscount;
        private System.Windows.Forms.ComboBox lbSortingPrice;
        private System.Windows.Forms.Label lblSortingPrice;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlDiscount;
        private System.Windows.Forms.Panel pnlProductDescription;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}