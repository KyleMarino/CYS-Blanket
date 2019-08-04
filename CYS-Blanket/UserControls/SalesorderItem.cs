using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CYS_Blanket.Classes;

namespace CYS_Blanket.UserControls
{
    public partial class SalesorderItem : UserControl
    {
        private Salesorder datasource;

        public string SalesorderID { get; set; }

        public SalesorderItem(Salesorder so)
        {
            InitializeComponent();
            datasource = so;

            this.Dock = DockStyle.Top;
            grpHeader.Text = "Salesorder - " + datasource.SalesorderID;

            lblSOID.Text = datasource.SalesorderID.ToString();
            lblPurchaseOrder.Text = datasource.PurchaseorderID;
            lblExpirationDate.Text = datasource.ExpireDate.ToShortDateString();

            grpHeader.Width = this.Width;
        }
    }
}
