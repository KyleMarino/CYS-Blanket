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
using System.Data.OleDb;

namespace CYS_Blanket.UserControls
{
    public partial class SalesorderItem : UserControl
    {
        private Salesorder datasource;
        private bool expanded;
        private int expandedHeight;

        private OleDbConnection conn;
        private List<SalesorderLineItem> lineitems;

        public string SalesorderID { get; set; }

        public SalesorderItem()
        {
            InitializeComponent();
            expanded = true;
            expandedHeight = this.Height;
            Contract();
        }
        public SalesorderItem(Salesorder so)
        {
            InitializeComponent();
            datasource = so;

            this.Dock = DockStyle.Top;
            grpHeader.Text = "Salesorder - " + datasource.SalesorderID;

            lblSOID.Text = datasource.SalesorderID.ToString();
            lblPurchaseOrder.Text = datasource.PurchaseorderID;
            lblExpirationDate.Text = datasource.ExpireDate.ToShortDateString();

            grpHeader.Width = this.Width - 10;
            expandedHeight = this.Height;
            expanded = true;

            conn = new OleDbConnection(Properties.Resources.DBConnectionString);

            Contract();
        }

        //Events
        public event EventHandler ToggleExpansion;
        protected virtual void OnToggleExpansion(EventArgs e)
        {
            EventHandler handler = ToggleExpansion;
            handler?.Invoke(this, e);

            grpDetails.Height = detailsPanel.Bottom + 2;
            this.Height = grpDetails.Height + 2;
        }
        private void grpHeader_DoubleClick(object sender, EventArgs e)
        {
            if(expanded == true)
            {
                Contract();
            }
            else
            {
                Expand();
            }
        }

        private void Expand()
        {
            grpDetails.Visible = true;
            expanded = true;

            //Get lineitems from database
            OleDbCommand cmd = new OleDbCommand("Select lineitem_id from SalesorderLineitems where salesorder_id = " + datasource.SalesorderID + ";", conn);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            lineitems = new List<SalesorderLineItem>();
            while (reader.Read())
            {
                SalesorderLineItem newItem = new SalesorderLineItem((int)(reader[0]));
                lineitems.Add(newItem);

                SalesorderLineItemItem newItemGUI = new SalesorderLineItemItem(newItem);
                newItemGUI.Dock = DockStyle.Top;

                detailsPanel.Controls.Add(newItemGUI);
                expandedHeight += newItemGUI.Height;
            }
            reader.Close();
            conn.Close();
            this.Height = detailsPanel.Bottom + 10;
        }

        private void Contract()
        {
            expandedHeight = this.Height;
            grpDetails.Visible = false;
            this.Height = grpHeader.Bottom;
            expanded = false;

            foreach(SalesorderLineItemItem li in detailsPanel.Controls)
            {
                detailsPanel.Controls.Remove(li);
            }
        }
    }
}
