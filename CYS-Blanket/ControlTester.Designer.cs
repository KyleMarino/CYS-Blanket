namespace CYS_Blanket
{
    partial class ControlTester
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
            this.customerItem1 = new CYS_Blanket.UserControls.CustomerItem();
            this.SuspendLayout();
            // 
            // customerItem1
            // 
            this.customerItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerItem1.CustomerID = 0;
            this.customerItem1.CustomerName = "";
            this.customerItem1.Location = new System.Drawing.Point(31, 47);
            this.customerItem1.Name = "customerItem1";
            this.customerItem1.Number = 0;
            this.customerItem1.Size = new System.Drawing.Size(712, 273);
            this.customerItem1.TabIndex = 0;
            // 
            // ControlTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerItem1);
            this.Name = "ControlTester";
            this.Text = "ControlTester";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.CustomerItem customerItem1;
    }
}