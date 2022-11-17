using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Admin.Order_Management
{
    public partial class frmOrderDetail : Form
    {
        public frmOrderDetail()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
        }

        public IProductRepository _productRepository;

        public IOrderDetailRepository orderDetailRepository;
        public OrderDetail OrderDetail { get; set; }

        bool updateOrInsert; //true if update

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadInfor();

            if (updateOrInsert)
            {
                cboProductID.Enabled = false;
            }

        }

        private void LoadInfor()
        {
            txtOrderID.Text = OrderDetail.OrderId.ToString();

            txtUnitPrice.Text = OrderDetail.UnitPrice.ToString();
            txtQuantity.Text = OrderDetail.Quantity.ToString();
            txtDiscount.Text = OrderDetail.Discount.ToString();

            List<int> products = _productRepository.GetProducts().Select(p => p.ProductId).ToList();

            cboProductID.DataSource = products;
            cboProductID.Text = OrderDetail.ProductId.ToString();
        }

        private void frmOrderDetail_Load_1(object sender, EventArgs e)
        {

        }
    }
}
