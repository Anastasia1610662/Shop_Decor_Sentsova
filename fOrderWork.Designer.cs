﻿namespace Shop_Decor_Sentsova
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOrderWork));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.cboSortingDiscount = new System.Windows.Forms.ComboBox();
            this.lblSortingDiscount = new System.Windows.Forms.Label();
            this.cboSortingPrice = new System.Windows.Forms.ComboBox();
            this.lblSortingPrice = new System.Windows.Forms.Label();
            this.dgvOrdersMA = new System.Windows.Forms.DataGridView();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblCostWithDiscount = new System.Windows.Forms.Label();
            this.lblProductManufacturer = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlDiscount = new System.Windows.Forms.Panel();
            this.pnlProductDescription = new System.Windows.Forms.Panel();
            this.lblCost = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDown.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlDiscount.SuspendLayout();
            this.pnlProductDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlUp);
            this.panel1.Controls.Add(this.dgvOrdersMA);
            this.panel1.Controls.Add(this.pnlDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 671);
            this.panel1.TabIndex = 0;
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlUp.Controls.Add(this.cboSortingDiscount);
            this.pnlUp.Controls.Add(this.lblSortingDiscount);
            this.pnlUp.Controls.Add(this.cboSortingPrice);
            this.pnlUp.Controls.Add(this.lblSortingPrice);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1256, 135);
            this.pnlUp.TabIndex = 4;
            // 
            // cboSortingDiscount
            // 
            this.cboSortingDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cboSortingDiscount.FormattingEnabled = true;
            this.cboSortingDiscount.Items.AddRange(new object[] {
            "Все диапазоны",
            "0-10%",
            "11-14%",
            "15% и более "});
            this.cboSortingDiscount.Location = new System.Drawing.Point(415, 34);
            this.cboSortingDiscount.Name = "cboSortingDiscount";
            this.cboSortingDiscount.Size = new System.Drawing.Size(232, 31);
            this.cboSortingDiscount.TabIndex = 6;
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
            // cboSortingPrice
            // 
            this.cboSortingPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cboSortingPrice.FormattingEnabled = true;
            this.cboSortingPrice.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.cboSortingPrice.Location = new System.Drawing.Point(57, 34);
            this.cboSortingPrice.Name = "cboSortingPrice";
            this.cboSortingPrice.Size = new System.Drawing.Size(232, 31);
            this.cboSortingPrice.TabIndex = 3;
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
            // dgvOrdersMA
            // 
            this.dgvOrdersMA.AllowUserToAddRows = false;
            this.dgvOrdersMA.AllowUserToDeleteRows = false;
            this.dgvOrdersMA.AllowUserToResizeColumns = false;
            this.dgvOrdersMA.AllowUserToResizeRows = false;
            this.dgvOrdersMA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdersMA.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdersMA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrdersMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdersMA.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrdersMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersMA.Location = new System.Drawing.Point(0, 0);
            this.dgvOrdersMA.Margin = new System.Windows.Forms.Padding(0);
            this.dgvOrdersMA.Name = "dgvOrdersMA";
            this.dgvOrdersMA.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdersMA.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrdersMA.Size = new System.Drawing.Size(1256, 536);
            this.dgvOrdersMA.TabIndex = 6;
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
            // lblCostWithDiscount
            // 
            this.lblCostWithDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostWithDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCostWithDiscount.Location = new System.Drawing.Point(246, 98);
            this.lblCostWithDiscount.Name = "lblCostWithDiscount";
            this.lblCostWithDiscount.Size = new System.Drawing.Size(523, 23);
            this.lblCostWithDiscount.TabIndex = 12;
            this.lblCostWithDiscount.Text = "Цена с";
            this.lblCostWithDiscount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblProductManufacturer
            // 
            this.lblProductManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductManufacturer.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblProductManufacturer.Location = new System.Drawing.Point(-2, 97);
            this.lblProductManufacturer.Name = "lblProductManufacturer";
            this.lblProductManufacturer.Size = new System.Drawing.Size(593, 23);
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
            this.lblProductDescription.Size = new System.Drawing.Size(766, 70);
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
            this.lblProductName.Size = new System.Drawing.Size(766, 25);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "Наименование товара: ";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnClose.Location = new System.Drawing.Point(1155, 99);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 33);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlDown.Controls.Add(this.btnClose);
            this.pnlDown.Controls.Add(this.pnlLogo);
            this.pnlDown.Controls.Add(this.pnlDiscount);
            this.pnlDown.Controls.Add(this.pnlProductDescription);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 536);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(1256, 135);
            this.pnlDown.TabIndex = 5;
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
            this.pnlProductDescription.Controls.Add(this.lblCostWithDiscount);
            this.pnlProductDescription.Controls.Add(this.lblCost);
            this.pnlProductDescription.Controls.Add(this.lblProductManufacturer);
            this.pnlProductDescription.Controls.Add(this.lblProductDescription);
            this.pnlProductDescription.Controls.Add(this.lblProductName);
            this.pnlProductDescription.Location = new System.Drawing.Point(186, 3);
            this.pnlProductDescription.Name = "pnlProductDescription";
            this.pnlProductDescription.Size = new System.Drawing.Size(776, 129);
            this.pnlProductDescription.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCost.Location = new System.Drawing.Point(153, 98);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(521, 23);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Цена без скидки:  ";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // fOrderWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 671);
            this.Controls.Add(this.panel1);
            this.Name = "fOrderWork";
            this.Text = "Работа с заказами";
            this.panel1.ResumeLayout(false);
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDown.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlDiscount.ResumeLayout(false);
            this.pnlProductDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.ComboBox cboSortingDiscount;
        private System.Windows.Forms.Label lblSortingDiscount;
        private System.Windows.Forms.ComboBox cboSortingPrice;
        private System.Windows.Forms.Label lblSortingPrice;
        private System.Windows.Forms.DataGridView dgvOrdersMA;
        private System.Windows.Forms.Panel pnlDown;
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
    }
}