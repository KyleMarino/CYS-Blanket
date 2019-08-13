using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYS_Blanket.Classes
{
    public class Salesorder
    {
        private OleDbConnection conn;

        public int SalesorderID { get; set; }
        public int CustomerID { get; set; }
        public int LineitemCount { get; set; }
        public double TotalQuantity { get; set; }
        public double TotalAmount { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string PurchaseorderID { get; set; }
        public List<SalesorderLineItem> lineitems { get; set; }
        public Salesorder()
        {
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
        }

        public Salesorder(int id)
        {
            //Get information about this salesorder from the database.
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
            OleDbCommand cmd = new OleDbCommand("Select * from Salesorders where salesorder_id = " + id + ";", conn);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                SalesorderID = (int)(reader[0]);
                CustomerID = (int)(reader[1]);
                LineitemCount = (int)(reader[2]);
                TotalQuantity = Convert.ToDouble(reader[3].ToString());
                TotalAmount = Convert.ToDouble(reader[4].ToString());
                IssueDate = (DateTime)(reader[5]);
                ExpireDate = (DateTime)(reader[6]);
                PurchaseorderID = reader[7].ToString();
            }
            reader.Close();
            conn.Close();
        }

        public void Save()
        {
            //TODO
            //Throw exception on failure.
            //Validate:
                //Are all properties filled out?
        }
    }
}
