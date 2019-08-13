﻿using System;
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

        public SalesorderLineItem(int ID)
        {
            //Get this line item from the database.
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
            OleDbCommand cmd = new OleDbCommand("select * from SalesorderLineitems where lineitem_id = " + ID + ";", conn);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LineitemID = (int)(reader[0]);
                Item = reader[1].ToString();
                Description = reader[2].ToString();
                Quantity = (int)(reader[3]);
                UnitOfMeasure = reader[4].ToString();
                Rate = Convert.ToDouble(reader[5]);
                Amount = Convert.ToDouble(reader[6]);
            }
            reader.Close();
            conn.Close();
        }
    }
}