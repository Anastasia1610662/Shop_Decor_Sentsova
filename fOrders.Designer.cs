﻿namespace Shop_Decor_Sentsova
{
    partial class fOrders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDiscount = new System.Windows.Forms.Panel();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlProductDescription = new System.Windows.Forms.Panel();
            this.lblCostDiscounts = new System.Windows.Forms.Label();
            this.lblCostS = new System.Windows.Forms.Label();
            this.lblCostWithDiscount = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.pnlPhotoProduct = new System.Windows.Forms.Panel();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.lblFIO = new System.Windows.Forms.Label();
            this.cboPickUpPoints = new System.Windows.Forms.ComboBox();
            this.lblSortingDiscount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pnlDown.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDiscount.SuspendLayout();
            this.pnlProductDescription.SuspendLayout();
            this.pnlPhotoProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.pnlUp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 362);
            this.panel1.TabIndex = 0;
            // 
            // lstOrders
            // 
            this.lstOrders.ContextMenuStrip = this.contextMenuStrip1;
            this.lstOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOrders.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 17;
            this.lstOrders.Location = new System.Drawing.Point(0, 0);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(985, 362);
            this.lstOrders.TabIndex = 6;
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlDown.Controls.Add(this.pnlLogo);
            this.pnlDown.Controls.Add(this.pnlDiscount);
            this.pnlDown.Controls.Add(this.pnlProductDescription);
            this.pnlDown.Controls.Add(this.pnlPhotoProduct);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(3, 501);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(985, 135);
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
            this.pnlDiscount.Controls.Add(this.btnTicket);
            this.pnlDiscount.Controls.Add(this.btnMakeOrder);
            this.pnlDiscount.Controls.Add(this.btnClose);
            this.pnlDiscount.Location = new System.Drawing.Point(697, 3);
            this.pnlDiscount.Name = "pnlDiscount";
            this.pnlDiscount.Size = new System.Drawing.Size(284, 129);
            this.pnlDiscount.TabIndex = 12;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnTicket.Location = new System.Drawing.Point(3, 43);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(274, 36);
            this.btnTicket.TabIndex = 17;
            this.btnTicket.Text = "Получить талон";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Visible = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnMakeOrder.Location = new System.Drawing.Point(3, 3);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(274, 38);
            this.btnMakeOrder.TabIndex = 16;
            this.btnMakeOrder.Text = "Заказать";
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnClose.Location = new System.Drawing.Point(3, 81);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(274, 41);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlProductDescription
            // 
            this.pnlProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProductDescription.Controls.Add(this.lblCostDiscounts);
            this.pnlProductDescription.Controls.Add(this.lblCostS);
            this.pnlProductDescription.Controls.Add(this.lblCostWithDiscount);
            this.pnlProductDescription.Controls.Add(this.lblCost);
            this.pnlProductDescription.Location = new System.Drawing.Point(359, 3);
            this.pnlProductDescription.Name = "pnlProductDescription";
            this.pnlProductDescription.Size = new System.Drawing.Size(332, 129);
            this.pnlProductDescription.TabIndex = 1;
            // 
            // lblCostDiscounts
            // 
            this.lblCostDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostDiscounts.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCostDiscounts.Location = new System.Drawing.Point(207, 49);
            this.lblCostDiscounts.Name = "lblCostDiscounts";
            this.lblCostDiscounts.Size = new System.Drawing.Size(118, 23);
            this.lblCostDiscounts.TabIndex = 15;
            this.lblCostDiscounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCostS
            // 
            this.lblCostS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostS.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCostS.Location = new System.Drawing.Point(3, 3);
            this.lblCostS.Name = "lblCostS";
            this.lblCostS.Size = new System.Drawing.Size(174, 23);
            this.lblCostS.TabIndex = 14;
            this.lblCostS.Text = "Итоговая стоимость:";
            this.lblCostS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCostWithDiscount
            // 
            this.lblCostWithDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostWithDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCostWithDiscount.Location = new System.Drawing.Point(173, 3);
            this.lblCostWithDiscount.Name = "lblCostWithDiscount";
            this.lblCostWithDiscount.Size = new System.Drawing.Size(152, 23);
            this.lblCostWithDiscount.TabIndex = 13;
            this.lblCostWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCost.Location = new System.Drawing.Point(3, 49);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(198, 23);
            this.lblCost.TabIndex = 12;
            this.lblCost.Text = "Итоговая сумма скидки:";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.picProduct.TabIndex = 4;
            this.picProduct.TabStop = false;
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlUp.Controls.Add(this.lblFIO);
            this.pnlUp.Controls.Add(this.cboPickUpPoints);
            this.pnlUp.Controls.Add(this.lblSortingDiscount);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(3, 3);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(985, 121);
            this.pnlUp.TabIndex = 4;
            // 
            // lblFIO
            // 
            this.lblFIO.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblFIO.Location = new System.Drawing.Point(662, 9);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(319, 80);
            this.lblFIO.TabIndex = 8;
            this.lblFIO.Text = "ФИО";
            this.lblFIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPickUpPoints
            // 
            this.cboPickUpPoints.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cboPickUpPoints.FormattingEnabled = true;
            this.cboPickUpPoints.Location = new System.Drawing.Point(140, 32);
            this.cboPickUpPoints.Name = "cboPickUpPoints";
            this.cboPickUpPoints.Size = new System.Drawing.Size(351, 31);
            this.cboPickUpPoints.TabIndex = 6;
            // 
            // lblSortingDiscount
            // 
            this.lblSortingDiscount.AutoSize = true;
            this.lblSortingDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblSortingDiscount.Location = new System.Drawing.Point(12, 35);
            this.lblSortingDiscount.Name = "lblSortingDiscount";
            this.lblSortingDiscount.Size = new System.Drawing.Size(131, 23);
            this.lblSortingDiscount.TabIndex = 5;
            this.lblSortingDiscount.Text = "Пункт выдачи: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlDown, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlUp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 639);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьТоварToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // удалитьТоварToolStripMenuItem
            // 
            this.удалитьТоварToolStripMenuItem.Name = "удалитьТоварToolStripMenuItem";
            this.удалитьТоварToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьТоварToolStripMenuItem.Text = "Удалить товар";
            this.удалитьТоварToolStripMenuItem.Click += new System.EventHandler(this.удалитьТоварToolStripMenuItem_Click);
            // 
            // fOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 639);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fOrders";
            this.Text = "Просмотр закза";
            this.panel1.ResumeLayout(false);
            this.pnlDown.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDiscount.ResumeLayout(false);
            this.pnlProductDescription.ResumeLayout(false);
            this.pnlPhotoProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlDiscount;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlProductDescription;
        private System.Windows.Forms.Label lblCostDiscounts;
        private System.Windows.Forms.Label lblCostS;
        private System.Windows.Forms.Label lblCostWithDiscount;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Panel pnlPhotoProduct;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.ComboBox cboPickUpPoints;
        private System.Windows.Forms.Label lblSortingDiscount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьТоварToolStripMenuItem;
    }
}