using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CYS_Blanket.Classes
{
    public class Location
    {
        private int id;
        private OleDbConnection conn;
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string Hours { get; set; }
        public string Comments { get; set; }
        public string Instructions { get; set; }

        public Location()
        {
            //New location
            conn = new OleDbConnection(Properties.Resources.DBConnectionString);

        }
        public Location(int ID)
        {
            conn = new OleDbConnection(Properties.Resources.DBConnectionString);
            this.Load(ID);
        }

        public void Load(int ID)
        {
            //Load the data from the database with the given ID
            OleDbCommand cmd = new OleDbCommand("Select * from Locations where location_id = " + ID + ";", conn);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = ID;
                Address1 = reader[1].ToString();
                Address2 = reader[2].ToString();
                City = reader[3].ToString();
                State = reader[4].ToString();
                Zip = reader[5].ToString();
                ContactName = reader[6].ToString();
                ContactPhone = reader[7].ToString();
                ContactEmail = reader[8].ToString();
                Hours = reader[9].ToString();
                Comments = reader[10].ToString();
                Instructions = reader[11].ToString();

            }

            conn.Close();
        }

    }
}
