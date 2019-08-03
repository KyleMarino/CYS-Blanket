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
    public partial class CustomerItem : UserControl
    {
        private int customer_id;
        private string customer_name;
        private int number;
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
            InitializeComponent();
            CustomerName = "";
        }
        public CustomerItem(Customer c)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            CustomerID = c.CustomerID;
            CustomerName = c.Name;
        }
    }
}
