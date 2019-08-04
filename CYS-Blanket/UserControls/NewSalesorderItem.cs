using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYS_Blanket.UserControls
{
    public partial class NewSalesorderItem : UserControl
    {
        public NewSalesorderItem()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate:
                //Are there lineitems?
                //Is the expiration date after today?
                //Is all the information filled out?
            //Create a new Salesorder, push to database.
        }
    }
}
