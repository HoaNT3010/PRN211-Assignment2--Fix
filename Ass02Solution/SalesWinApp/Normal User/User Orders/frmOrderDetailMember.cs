using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Normal_User.User_Orders
{
    public partial class frmOrderDetailMember : Form
    {
        public OrderDetail OrderDetail { get; set; }

        public frmOrderDetailMember()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrderDetailMember_Load(object sender, EventArgs e)
        {
            if(OrderDetail != null)
            {
                txtOrderID.Text = OrderDetail.OrderId.ToString();
                cboProductID.Text = OrderDetail.ProductId.ToString();
                txtUnitPrice.Text = OrderDetail.UnitPrice.ToString();
                txtQuantity.Text = OrderDetail.Quantity.ToString();
                txtDiscount.Text = OrderDetail.Discount.ToString();
            }
            else
            {
                MessageBox.Show("Cannot Load Order Detail!");
                btnClose_Click(sender, e);
            }
        }

        private void frmOrderDetailMember_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
