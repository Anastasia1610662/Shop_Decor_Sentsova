﻿namespace Shop_Decor_Sentsova
{
    partial class fTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTicket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.lblTicket = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.lstTicket = new System.Windows.Forms.ListBox();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblOrderCode = new System.Windows.Forms.Label();
            this.lblPickUpPoint = new System.Windows.Forms.Label();
            this.lblCostDiscounts = new System.Windows.Forms.Label();
            this.lblCostWithDiscount = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDown.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 609);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlUp);
            this.panel2.Controls.Add(this.lstTicket);
            this.panel2.Controls.Add(this.pnlDown);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 609);
            this.panel2.TabIndex = 1;
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlUp.Controls.Add(this.lblTicket);
            this.pnlUp.Controls.Add(this.picLogo);
            this.pnlUp.Controls.Add(this.lblShopName);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(309, 100);
            this.pnlUp.TabIndex = 5;
            // 
            // lblTicket
            // 
            this.lblTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTicket.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTicket.Location = new System.Drawing.Point(12, 52);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(161, 37);
            this.lblTicket.TabIndex = 2;
            this.lblTicket.Text = "Заказ";
            this.lblTicket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.lblShopName.Location = new System.Drawing.Point(12, 9);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(161, 23);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "ООО «Украшение»";
            // 
            // lstTicket
            // 
            this.lstTicket.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lstTicket.FormattingEnabled = true;
            this.lstTicket.HorizontalScrollbar = true;
            this.lstTicket.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstTicket.ItemHeight = 17;
            this.lstTicket.Location = new System.Drawing.Point(0, 100);
            this.lstTicket.Margin = new System.Windows.Forms.Padding(0);
            this.lstTicket.Name = "lstTicket";
            this.lstTicket.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTicket.Size = new System.Drawing.Size(309, 208);
            this.lstTicket.Sorted = true;
            this.lstTicket.TabIndex = 7;
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.pnlDown.Controls.Add(this.pnlBottom);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 307);
            this.pnlDown.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(309, 302);
            this.pnlDown.TabIndex = 6;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.lblOrderCode);
            this.pnlBottom.Controls.Add(this.lblPickUpPoint);
            this.pnlBottom.Controls.Add(this.lblCostDiscounts);
            this.pnlBottom.Controls.Add(this.lblCostWithDiscount);
            this.pnlBottom.Controls.Add(this.lblOrderDate);
            this.pnlBottom.Location = new System.Drawing.Point(3, 3);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(303, 296);
            this.pnlBottom.TabIndex = 0;
            // 
            // lblOrderCode
            // 
            this.lblOrderCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderCode.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblOrderCode.Location = new System.Drawing.Point(3, 5);
            this.lblOrderCode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblOrderCode.Name = "lblOrderCode";
            this.lblOrderCode.Size = new System.Drawing.Size(289, 42);
            this.lblOrderCode.TabIndex = 19;
            this.lblOrderCode.Text = "Код заказа\r\n";
            this.lblOrderCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPickUpPoint
            // 
            this.lblPickUpPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPickUpPoint.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblPickUpPoint.Location = new System.Drawing.Point(3, 136);
            this.lblPickUpPoint.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblPickUpPoint.Name = "lblPickUpPoint";
            this.lblPickUpPoint.Size = new System.Drawing.Size(293, 73);
            this.lblPickUpPoint.TabIndex = 18;
            this.lblPickUpPoint.Text = "Пункт выдачи: ";
            // 
            // lblCostDiscounts
            // 
            this.lblCostDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostDiscounts.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCostDiscounts.Location = new System.Drawing.Point(3, 108);
            this.lblCostDiscounts.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblCostDiscounts.Name = "lblCostDiscounts";
            this.lblCostDiscounts.Size = new System.Drawing.Size(293, 23);
            this.lblCostDiscounts.TabIndex = 17;
            this.lblCostDiscounts.Text = "Сумма скидки: ";
            this.lblCostDiscounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCostWithDiscount
            // 
            this.lblCostWithDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostWithDiscount.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblCostWithDiscount.Location = new System.Drawing.Point(3, 80);
            this.lblCostWithDiscount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblCostWithDiscount.Name = "lblCostWithDiscount";
            this.lblCostWithDiscount.Size = new System.Drawing.Size(289, 23);
            this.lblCostWithDiscount.TabIndex = 16;
            this.lblCostWithDiscount.Text = "Сумма заказа: ";
            this.lblCostWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderDate.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblOrderDate.Location = new System.Drawing.Point(3, 52);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(293, 23);
            this.lblOrderDate.TabIndex = 15;
            this.lblOrderDate.Text = "Дата заказа:";
            this.lblOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 609);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fTicket";
            this.Text = "Заказ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDown.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.ListBox lstTicket;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblOrderCode;
        private System.Windows.Forms.Label lblPickUpPoint;
        private System.Windows.Forms.Label lblCostDiscounts;
        private System.Windows.Forms.Label lblCostWithDiscount;
        private System.Windows.Forms.Label lblOrderDate;
    }
}