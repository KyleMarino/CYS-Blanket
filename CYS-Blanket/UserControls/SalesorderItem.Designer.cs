namespace CYS_Blanket.UserControls
{
    partial class SalesorderItem
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
            this.grpHeader = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPurchaseOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSOID = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.detailsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.grpHeader.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHeader
            // 
            this.grpHeader.Controls.Add(this.label4);
            this.grpHeader.Controls.Add(this.lblExpirationDate);
            this.grpHeader.Controls.Add(this.label2);
            this.grpHeader.Controls.Add(this.lblPurchaseOrder);
            this.grpHeader.Controls.Add(this.label1);
            this.grpHeader.Controls.Add(this.lblSOID);
            this.grpHeader.Controls.Add(this.lblNumber);
            this.grpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHeader.Location = new System.Drawing.Point(0, 0);
            this.grpHeader.Name = "grpHeader";
            this.grpHeader.Size = new System.Drawing.Size(1255, 72);
            this.grpHeader.TabIndex = 0;
            this.grpHeader.TabStop = false;
            this.grpHeader.Text = "Salesorder - ";
            this.grpHeader.DoubleClick += new System.EventHandler(this.grpHeader_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Expiration Date:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(505, 32);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(76, 13);
            this.lblExpirationDate.TabIndex = 5;
            this.lblExpirationDate.Text = "ExpirationDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PO#";
            // 
            // lblPurchaseOrder
            // 
            this.lblPurchaseOrder.AutoSize = true;
            this.lblPurchaseOrder.Location = new System.Drawing.Point(270, 32);
            this.lblPurchaseOrder.Name = "lblPurchaseOrder";
            this.lblPurchaseOrder.Size = new System.Drawing.Size(113, 13);
            this.lblPurchaseOrder.TabIndex = 3;
            this.lblPurchaseOrder.Text = "PurchaseorderNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SO#";
            // 
            // lblSOID
            // 
            this.lblSOID.AutoSize = true;
            this.lblSOID.Location = new System.Drawing.Point(112, 32);
            this.lblSOID.Name = "lblSOID";
            this.lblSOID.Size = new System.Drawing.Size(94, 13);
            this.lblSOID.TabIndex = 1;
            this.lblSOID.Text = "SalesorderNumber";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(24, 32);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(14, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "#";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.detailsPanel);
            this.grpDetails.Location = new System.Drawing.Point(4, 79);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(1248, 378);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Salesorder Details";
            // 
            // detailsPanel
            // 
            this.detailsPanel.AutoSize = true;
            this.detailsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.detailsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(3, 16);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(1242, 359);
            this.detailsPanel.TabIndex = 0;
            // 
            // SalesorderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpHeader);
            this.Name = "SalesorderItem";
            this.Size = new System.Drawing.Size(1255, 465);
            this.grpHeader.ResumeLayout(false);
            this.grpHeader.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPurchaseOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSOID;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.FlowLayoutPanel detailsPanel;
    }
}
