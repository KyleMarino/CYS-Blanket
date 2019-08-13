using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYS_Blanket.Classes
{
    public class SalesorderLineItem
    {
        private int LineitemID { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }

        private OleDbConnection conn;
        public SalesorderLineItem()
        {
            conn = new OleDbConnection(Properties.Resources.DBConnectionString);
        }

        public SalesorderLineItem(int ID)
        {
            //Get this line item from the database.
            conn = new OleDbConnection(Properties.Resources.DBConnectionString);
            OleDbCommand cmd = new OleDbCommand("select * from SalesorderLineitems where lineitem_id = " + ID + ";", conn);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LineitemID = (int)(reader[0]);
                Item = reader[2].ToString();
                Description = reader[3].ToString();
                Quantity = (int)(reader[4]);
                UnitOfMeasure = reader[5].ToString();
                Rate = Convert.ToDouble(reader[6]);
                Amount = Convert.ToDouble(reader[7]);
            }
            reader.Close();
            conn.Close();
        }
    }
}
