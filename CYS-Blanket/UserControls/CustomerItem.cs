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
    public partial class CustomerItem : UserControl
    {
        private int customer_id;
        private string customer_name;
        private bool expanded;
        private int expandedHeight;
        private int number;
        private OleDbConnection conn;
        private List<Salesorder> salesorders;
        
        //Properties
        public int CustomerID
        {
            get{return customer_id;}
            set{ customer_id = value;}
        }
        public string CustomerName
        {
            get { return this.customer_name; }
            set
            {
                this.customer_name = value;
                lblName.Text = value;
            }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        //Events

      
        //Constructors
        public CustomerItem()
        {
            Setup();
            Contract();
        }
        public CustomerItem(Customer c)
        {
            Setup();
            this.Dock = DockStyle.Top;
            CustomerID = c.CustomerID;
            CustomerName = c.Name;
            expandedHeight = this.Height;

            Contract();
        }

        public void Resize(int height, int width)
        {
            this.Height = height;
            this.Width = width;

            grpHeader.Width = width;
            grpDetail.Width = width;
            detailPanel.Width = width;
        }

        private void Setup()
        {
            InitializeComponent();
            CustomerName = "";
            expanded = true;
            expandedHeight = this.Height;

            grpHeader.Width = this.Width;

            if (Properties.Settings.Default.Environment == "DEV")
            {
                conn = new OleDbConnection(Properties.Resources.DevDBConnectionString);
            }
            else if (Properties.Settings.Default.Environment == "QA")
            {
                conn = new OleDbConnection(Properties.Resources.QADBConnectionString);
            }
            else if (Properties.Settings.Default.Environment == "PROD")
            {
                conn = new OleDbConnection(Properties.Resources.ProdDBConnectionString);
            }
            salesorders = new List<Salesorder>();

        }
        private void grpHeader_DblClick(object sender, EventArgs e)
        {
            if(expanded == false)
            {
                Expand();
            }
            else
            {
                Contract();
            }

        }
        private void Expand()
        {
            //Expand to show detail panel
            this.expanded = true;
            this.Height = expandedHeight;

            grpDetail.Visible = true;
            //Get SO's from database
            salesorders = new List<Salesorder>();
            OleDbCommand cmd = new OleDbCommand("Select salesorder_id from Salesorders where salesorder_customer_id = " + customer_id + ";", conn);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                salesorders.Add(new Salesorder((int)(reader[0])));
            }
            reader.Close();
            conn.Close();
            //Display Salesorders:
            foreach(Salesorder so in salesorders)
            {
                SalesorderItem newSO = new SalesorderItem(so);
                detailPanel.Controls.Add(newSO);
            }
            detailPanel.Controls.Add(new NewSalesorderItem());
        }
        public void Contract() //Public so it can be called by a "collapse all" button on the main form.
        {
            if(expanded == false) { return; }

            //Hide the detail panel
            this.expanded = false;
            expandedHeight = this.Height;
            this.Height = grpHeader.Bottom + 2;

            //Clear grpDetail
            foreach(Control c in detailPanel.Controls)
            {
                detailPanel.Controls.Remove(c);
            }
            grpDetail.Visible = false;
        }
    }
}
