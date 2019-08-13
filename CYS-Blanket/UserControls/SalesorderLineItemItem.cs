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
    public partial class SalesorderLineItemItem : UserControl
    {

        private SalesorderLineItem salesorder_lineitem;
        public SalesorderLineItemItem()
        {
            InitializeComponent();
        }

        public SalesorderLineItemItem(SalesorderLineItem so)
        {
            InitializeComponent();

            salesorder_lineitem = so;
            lblItem.Text = so.Item;
            lblDescription.Text = so.Description;
            lblQuantity.Text = so.Quantity.ToString();
            lblQtyUOM.Text = so.UnitOfMeasure;
            lblRate.Text = so.Rate.ToString();
            lblAmount.Text = so.Amount.ToString();
        }
    }
}
