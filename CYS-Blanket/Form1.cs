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
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //List customers in the database.
             conn = new OleDbConnection(Properties.Resources.DBConnectionString);

            LoadCustomers();
        }

        private void LoadCustomers()
        {
            OleDbCommand cmd;
            OleDbDataReader reader;

            cmd = new OleDbCommand("Select customer_id from Customers order by customer_id desc", conn);
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
                newC.Resize(newC.Height, customerPanel.Width -10);
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
    }
}
