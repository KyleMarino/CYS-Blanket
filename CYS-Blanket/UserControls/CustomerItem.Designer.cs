namespace CYS_Blanket.UserControls
{
    partial class CustomerItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.grpHeader = new System.Windows.Forms.GroupBox();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.detailPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.grpHeader.SuspendLayout();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(19, 27);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(14, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "#";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // grpHeader
            // 
            this.grpHeader.Controls.Add(this.lblName);
            this.grpHeader.Controls.Add(this.lblNumber);
            this.grpHeader.Location = new System.Drawing.Point(3, 3);
            this.grpHeader.Name = "grpHeader";
            this.grpHeader.Size = new System.Drawing.Size(561, 64);
            this.grpHeader.TabIndex = 2;
            this.grpHeader.TabStop = false;
            this.grpHeader.DoubleClick += new System.EventHandler(this.grpHeader_DblClick);
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.detailPanel);
            this.grpDetail.Location = new System.Drawing.Point(4, 74);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(560, 305);
            this.grpDetail.TabIndex = 3;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Details";
            // 
            // detailPanel
            // 
            this.detailPanel.AutoSize = true;
            this.detailPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.detailPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.detailPanel.Location = new System.Drawing.Point(6, 19);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(0, 0);
            this.detailPanel.TabIndex = 0;
            // 
            // CustomerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.grpHeader);
            this.Name = "CustomerItem";
            this.Size = new System.Drawing.Size(567, 383);
            this.grpHeader.ResumeLayout(false);
            this.grpHeader.PerformLayout();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpHeader;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.FlowLayoutPanel detailPanel;
    }
}
