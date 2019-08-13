namespace CYS_Blanket.UserControls
{
    partial class SalesorderLineItemItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblQtyUOM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(18, 36);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(14, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "#";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(69, 36);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "Item";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(131, 36);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(237, 36);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(495, 36);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(417, 36);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 5;
            this.lblRate.Text = "Rate";
            // 
            // lblQtyUOM
            // 
            this.lblQtyUOM.AutoSize = true;
            this.lblQtyUOM.Location = new System.Drawing.Point(318, 36);
            this.lblQtyUOM.Name = "lblQtyUOM";
            this.lblQtyUOM.Size = new System.Drawing.Size(48, 13);
            this.lblQtyUOM.TabIndex = 6;
            this.lblQtyUOM.Text = "QtyUOM";
            // 
            // SalesorderLineItemItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblQtyUOM);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblNumber);
            this.Name = "SalesorderLineItemItem";
            this.Size = new System.Drawing.Size(985, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblQtyUOM;
    }
}
