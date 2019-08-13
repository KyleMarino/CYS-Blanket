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
            this.btnControlTest = new System.Windows.Forms.Button();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.btnCollapseAll = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.panelBackground = new System.Windows.Forms.FlowLayoutPanel();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.grpCustomers.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnControlTest
            // 
            this.btnControlTest.Location = new System.Drawing.Point(1083, 27);
            this.btnControlTest.Name = "btnControlTest";
            this.btnControlTest.Size = new System.Drawing.Size(139, 30);
            this.btnControlTest.TabIndex = 3;
            this.btnControlTest.Text = "ControlTester";
            this.btnControlTest.UseVisualStyleBackColor = true;
            this.btnControlTest.Click += new System.EventHandler(this.btnControlTest_Click);
            // 
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.customerPanel);
            this.grpCustomers.Location = new System.Drawing.Point(3, 93);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(1001, 410);
            this.grpCustomers.TabIndex = 1;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Text = "Customers";
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Location = new System.Drawing.Point(3, 57);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(139, 30);
            this.btnCollapseAll.TabIndex = 2;
            this.btnCollapseAll.Text = "CollapseAll";
            this.btnCollapseAll.UseVisualStyleBackColor = true;
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Location = new System.Drawing.Point(3, 3);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1001, 48);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Customers";
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.grpFilter);
            this.panelBackground.Controls.Add(this.btnCollapseAll);
            this.panelBackground.Controls.Add(this.grpCustomers);
            this.panelBackground.Location = new System.Drawing.Point(12, 12);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1017, 550);
            this.panelBackground.TabIndex = 4;
            // 
            // customerPanel
            // 
            this.customerPanel.AutoSize = true;
            this.customerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customerPanel.Location = new System.Drawing.Point(7, 16);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(0, 0);
            this.customerPanel.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 575);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.btnControlTest);
            this.Name = "frmMain";
            this.Text = "CYS - Blanket Order System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpCustomers.ResumeLayout(false);
            this.grpCustomers.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnControlTest;
        private System.Windows.Forms.GroupBox grpCustomers;
        private System.Windows.Forms.Button btnCollapseAll;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.FlowLayoutPanel panelBackground;
        private System.Windows.Forms.Panel customerPanel;
    }
}

