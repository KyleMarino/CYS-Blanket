using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CYS_Blanket.Classes;
using CYS_Blanket.UserControls;

namespace CYS_Blanket
{
    public partial class frmMain : Form
    {
        private List<Customer> customers;
        private OleDbConnection conn;
        public frmMain()
        {
            InitializeComponent();
            customers = new List<Customer>();

            this.WindowState = FormWindowState.Maximized;

            customerPanel.Width = grpCustomers.Width-2;
            customerPanel.Height = grpCustomers.Height-2;
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //List customers in the database.
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

            
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            OleDbCommand cmd;
            OleDbDataReader reader;

            cmd = new OleDbCommand("Select customer_id from Customers order by customer_id desc", conn);
            //cmd = new OleDbCommand("Select customer_id from Customers where customer_id = 5 order by customer_id desc", conn);
            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customers.Add(new Customer((int)(reader[0])));
            }
            reader.Close();
            conn.Close();

            foreach(Customer c in customers)
            {
                CustomerItem newC = new CustomerItem(c);
                newC.Resize(100, grpCustomers.Width -10);
                customerPanel.Controls.Add(newC);
            }
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            foreach(CustomerItem c in customerPanel.Controls)
            {
                c.Contract();
            }
        }

        private void btnControlTest_Click(object sender, EventArgs e)
        {
            ControlTester tester = new ControlTester();

            tester.Show();
        }

    }
}
