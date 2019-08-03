namespace CYS_Blanket
{
    partial class frmMain
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
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.grpCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.Location = new System.Drawing.Point(22, 21);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(920, 64);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Customers";
            // 
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.customerPanel);
            this.grpCustomers.Location = new System.Drawing.Point(22, 101);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(920, 410);
            this.grpCustomers.TabIndex = 1;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Text = "Customers";
            // 
            // customerPanel
            // 
            this.customerPanel.Location = new System.Drawing.Point(20, 32);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(865, 346);
            this.customerPanel.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 575);
            this.Controls.Add(this.grpCustomers);
            this.Controls.Add(this.grpFilter);
            this.Name = "frmMain";
            this.Text = "CYS - Blanket Order System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.GroupBox grpCustomers;
        private System.Windows.Forms.Panel customerPanel;
    }
}

