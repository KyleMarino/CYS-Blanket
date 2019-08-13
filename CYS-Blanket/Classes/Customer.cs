using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYS_Blanket.Classes
{
    public class Customer
    {
        private int id;
        private List<Location> locations;
        private OleDbConnection conn;

        //Properties
        public string Name { get; set; }
        public int CustomerID {
            get
            {
                return id;
            }
            set
            {
                id = value;
                Load();
            }
        }
        public Location DefaultLocation { get; set; } //Set should update the database.
        public List<Location> Locations
        {
            get
            {
                return locations; //Byref or byval? TODO
            }
            set
            {
                locations = value;
            }
        }
        public string DefaultContactName { get; set; }
        public string DefaultContactPhone { get; set; }
        public string DefaultContactEmail { get; set; }

        public Customer(int ID)
        {
            if (Properties.Settings.Default.Environment == "DEV")
            {
                conn = new OleDbConnection(Properties.Resources.DevDBConnectionString);
            }else if(Properties.Settings.Default.Environment == "QA")
            {
                conn = new OleDbConnection(Properties.Resources.QADBConnectionString);
            }
            else if(Properties.Settings.Default.Environment == "PROD")
            {
                conn = new OleDbConnection(Properties.Resources.ProdDBConnectionString);
            }
            this.CustomerID = ID;

            Load();
         
        }

        private void Load()
        {
            //Clear old locations
            locations = new List<Location>();
            //Get data from database:
            OleDbCommand cmd;
            OleDbDataReader reader;
            //Get customer info from database:
            cmd = new OleDbCommand("Select * from Customers where customer_id = " + id + ";", conn);
            conn.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                this.Name = reader[1].ToString();
                this.DefaultContactName = reader[2].ToString();
                this.DefaultContactPhone = reader[3].ToString();
                this.DefaultContactEmail = reader[4].ToString();
                this.DefaultLocation = new Location((int)(reader[5]));
            }

            conn.Close();
            //Get locations from database
            cmd = new OleDbCommand("Select location_id from CustomerLocationLink where customer_id = " + id + ";", conn);
            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows) {
                //Grab the first result
                reader.Read();
                Locations.Add(new Location((int)(reader[0])));
            }
            conn.Close();
        }
    }
}
