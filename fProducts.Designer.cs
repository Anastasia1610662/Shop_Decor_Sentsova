namespace Shop_Decor_Sentsova
{
    partial class fProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProducts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.lblFIO = new System.Windows.Forms.Label();
            this.lbSortingDiscount = new System.Windows.Forms.ComboBox();
            this.lblSortingDiscount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lbSortingPrice = new System.Windows.Forms.ComboBox();
            this.lblSortingPrice = new System.Windows.Forms.Label();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDiscount = new System.Windows.Forms.Panel();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pnlProductDescription = new System.Windows.Forms.Panel();
            this.lblCostWithDiscount = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblProductManufacturer = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlPhotoProduct = new System.Windows.Forms.Panel();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlDown.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDiscount.SuspendLayout();
            this.pnlProductDescription.SuspendLayout();
            this.pnlPhotoProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 718);
            this.panel1.TabIndex = 0;
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlUp.Controls.Add(this.lblFIO);
            this.pnlUp.Controls.Add(this.lbSortingDiscount);
            this.pnlUp.Controls.Add(this.lblSortingDiscount);
            this.pnlUp.Controls.Add(this.lblCount);
            this.pnlUp.Controls.Add(this.lbSortingPrice);
            this.pnlUp.Controls.Add(this.lblSortingPrice);
            this.pnlUp.Controls.Add(this.tbSearchProduct);
            this.pnlUp.Controls.Add(this.lblSearchProduct);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUp.Location = new System.Drawing.Point(3, 3);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(977, 137);
            this.pnlUp.TabIndex = 3;
            // 
            // lblFIO
            // 
            this.lblFIO.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblFIO.Location = new System.Drawing.Point(662, 9);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(319, 80);
            this.lblFIO.TabIndex = 7;
            this.lblFIO.Text = "ФИО";
            this.lblFIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSortingDiscount
            // 
            this.lbSortingDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbSortingDiscount.FormattingEnabled = true;
            this.lbSortingDiscount.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-9,99%",
            "10-14,99%",
            "15% и более "});
            this.lbSortingDiscount.Location = new System.Drawing.Point(424, 35);
            this.lbSortingDiscount.Name = "lbSortingDiscount";
            this.lbSortingDiscount.Size = new System.Drawing.Size(232, 31);
            this.lbSortingDiscount.TabIndex = 6;
            this.lbSortingDiscount.SelectedIndexChanged += new System.EventHandler(this.lbSortingDiscount_SelectedIndexChanged);
            // 
            // lblSortingDiscount
            // 
            this.lblSortingDiscount.AutoSize = true;
            this.lblSortingDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblSortingDiscount.Location = new System.Drawing.Point(436, 9);
            this.lblSortingDiscount.Name = "lblSortingDiscount";
            this.lblSortingDiscount.Size = new System.Drawing.Size(210, 23);
            this.lblSortingDiscount.TabIndex = 5;
            this.lblSortingDiscount.Text = "Отфильтровать по скидке";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCount.Location = new System.Drawing.Point(7, 83);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(173, 23);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Количество товаров: ";
            // 
            // lbSortingPrice
            // 
            this.lbSortingPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lbSortingPrice.FormattingEnabled = true;
            this.lbSortingPrice.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.lbSortingPrice.Location = new System.Drawing.Point(186, 34);
            this.lbSortingPrice.Name = "lbSortingPrice";
            this.lbSortingPrice.Size = new System.Drawing.Size(232, 31);
            this.lbSortingPrice.TabIndex = 3;
            // 
            // lblSortingPrice
            // 
            this.lblSortingPrice.AutoSize = true;
            this.lblSortingPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblSortingPrice.Location = new System.Drawing.Point(182, 8);
            this.lblSortingPrice.Name = "lblSortingPrice";
            this.lblSortingPrice.Size = new System.Drawing.Size(236, 23);
            this.lblSortingPrice.TabIndex = 2;
            this.lblSortingPrice.Text = "Отсортировать по стоимости";
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.tbSearchProduct.Location = new System.Drawing.Point(8, 34);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(172, 30);
            this.tbSearchProduct.TabIndex = 1;
            this.tbSearchProduct.TextChanged += new System.EventHandler(this.tbSearchProduct_TextChanged);
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblSearchProduct.Location = new System.Drawing.Point(36, 9);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(115, 23);
            this.lblSearchProduct.TabIndex = 0;
            this.lblSearchProduct.Text = "Поиск товара";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(0, 138, 0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.Size = new System.Drawing.Size(977, 425);
            this.dgvProducts.TabIndex = 5;
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlDown.Controls.Add(this.btnShowOrder);
            this.pnlDown.Controls.Add(this.btnWork);
            this.pnlDown.Controls.Add(this.btnClose);
            this.pnlDown.Controls.Add(this.pnlLogo);
            this.pnlDown.Controls.Add(this.pnlDiscount);
            this.pnlDown.Controls.Add(this.pnlProductDescription);
            this.pnlDown.Controls.Add(this.pnlPhotoProduct);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDown.Location = new System.Drawing.Point(3, 577);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(977, 138);
            this.pnlDown.TabIndex = 4;
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnShowOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnShowOrder.Location = new System.Drawing.Point(697, 99);
            this.btnShowOrder.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(179, 33);
            this.btnShowOrder.TabIndex = 17;
            this.btnShowOrder.Text = "Просмотр заказа";
            this.btnShowOrder.UseVisualStyleBackColor = false;
            this.btnShowOrder.Visible = false;
            // 
            // btnWork
            // 
            this.btnWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnWork.Location = new System.Drawing.Point(697, 65);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(277, 33);
            this.btnWork.TabIndex = 18;
            this.btnWork.Text = "Работа с заказами";
            this.btnWork.UseVisualStyleBackColor = false;
            this.btnWork.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnClose.Location = new System.Drawing.Point(884, 99);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 33);
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
            this.pnlDiscount.Location = new System.Drawing.Point(697, 3);
            this.pnlDiscount.Name = "pnlDiscount";
            this.pnlDiscount.Size = new System.Drawing.Size(284, 56);
            this.pnlDiscount.TabIndex = 12;
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
            // pnlProductDescription
            // 
            this.pnlProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProductDescription.Controls.Add(this.lblCostWithDiscount);
            this.pnlProductDescription.Controls.Add(this.lblCost);
            this.pnlProductDescription.Controls.Add(this.lblProductManufacturer);
            this.pnlProductDescription.Controls.Add(this.lblProductDescription);
            this.pnlProductDescription.Controls.Add(this.lblProductName);
            this.pnlProductDescription.Location = new System.Drawing.Point(359, 3);
            this.pnlProductDescription.Name = "pnlProductDescription";
            this.pnlProductDescription.Size = new System.Drawing.Size(332, 129);
            this.pnlProductDescription.TabIndex = 1;
            // 
            // lblCostWithDiscount
            // 
            this.lblCostWithDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostWithDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCostWithDiscount.Location = new System.Drawing.Point(246, 98);
            this.lblCostWithDiscount.Name = "lblCostWithDiscount";
            this.lblCostWithDiscount.Size = new System.Drawing.Size(79, 23);
            this.lblCostWithDiscount.TabIndex = 12;
            this.lblCostWithDiscount.Text = "Цена с";
            this.lblCostWithDiscount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCost.Location = new System.Drawing.Point(153, 98);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(77, 23);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Цена без скидки:  ";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblProductManufacturer
            // 
            this.lblProductManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductManufacturer.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblProductManufacturer.Location = new System.Drawing.Point(-2, 97);
            this.lblProductManufacturer.Name = "lblProductManufacturer";
            this.lblProductManufacturer.Size = new System.Drawing.Size(149, 23);
            this.lblProductManufacturer.TabIndex = 9;
            this.lblProductManufacturer.Text = "Производитель: ";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductDescription.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblProductDescription.Location = new System.Drawing.Point(3, 28);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(322, 70);
            this.lblProductDescription.TabIndex = 8;
            this.lblProductDescription.Text = "Описание товара: ";
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductName.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblProductName.Location = new System.Drawing.Point(3, 3);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(322, 25);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "Наименование товара: ";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlPhotoProduct
            // 
            this.pnlPhotoProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPhotoProduct.Controls.Add(this.picProduct);
            this.pnlPhotoProduct.Location = new System.Drawing.Point(186, 3);
            this.pnlPhotoProduct.Name = "pnlPhotoProduct";
            this.pnlPhotoProduct.Size = new System.Drawing.Size(167, 129);
            this.pnlPhotoProduct.TabIndex = 0;
            // 
            // picProduct
            // 
            this.picProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picProduct.Image = ((System.Drawing.Image)(resources.GetObject("picProduct.Image")));
            this.picProduct.Location = new System.Drawing.Point(3, 3);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(157, 119);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlUp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDown, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.95512F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.04488F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(983, 718);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 425);
            this.panel2.TabIndex = 6;
            // 
            // fProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 718);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список товаров";
            this.panel1.ResumeLayout(false);
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlDown.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDiscount.ResumeLayout(false);
            this.pnlProductDescription.ResumeLayout(false);
            this.pnlPhotoProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.ComboBox lbSortingDiscount;
        private System.Windows.Forms.Label lblSortingDiscount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ComboBox lbSortingPrice;
        private System.Windows.Forms.Label lblSortingPrice;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Button btnShowOrder;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlDiscount;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel pnlProductDescription;
        private System.Windows.Forms.Label lblCostWithDiscount;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblProductManufacturer;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel pnlPhotoProduct;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}