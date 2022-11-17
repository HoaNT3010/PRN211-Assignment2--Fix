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
using static System.Net.Mime.MediaTypeNames;

namespace SalesWinApp.Admin.Order_Management
{
    public partial class frmOrderDetail : Form
    {
        public frmOrderDetail()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            orderDetailRepository = new OrderDetailRepository();
            orderRepository =  new OrderRepository();
        }

        public IProductRepository _productRepository;

        public IOrderDetailRepository orderDetailRepository;

        public IOrderRepository orderRepository;
        public OrderDetail OrderDetail { get; set; }
        public int OrderID { get; set; }

        public bool updateOrInsert; //true if update

        public List<Product> products { get; set; }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadInfor();

            if (updateOrInsert)
            {
                cboProductID.Enabled = false;
                cboProductID.Text = OrderDetail.ProductId.ToString();
            }

        }

        private void LoadInfor()
        {
            txtOrderID.Text = OrderID.ToString();

            cboProductID.DataSource = null;
            cboProductID.DataSource = products;
            cboProductID.DisplayMember = "ProductId";
            cboProductID.ValueMember = "ProductId";

            if (OrderDetail != null)
            {
                txtUnitPrice.Text = OrderDetail.UnitPrice.ToString();
                txtQuantity.Text = OrderDetail.Quantity.ToString();
                txtDiscount.Text = OrderDetail.Discount.ToString();

                //products = _productRepository.GetProducts().Select(p => p.ProductId).ToList();
            }
            else
            {
                var tmpProduct = _productRepository.GetProduct(int.Parse(cboProductID.SelectedValue.ToString()));
                txtUnitPrice.Text = tmpProduct.UnitPrice.ToString();
            }

        }




        private void frmOrderDetail_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetailItem = new OrderDetail();
            if (txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("All fields are required.");
            }
            else if (txtDiscount.Text.Trim() == "")
            {
                MessageBox.Show("All fields are required.");
            }
            else
            {
                try
                {
                    orderDetailItem.OrderId = OrderID;
                    orderDetailItem.ProductId = int.Parse(cboProductID.SelectedValue.ToString());
                    orderDetailItem.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                    orderDetailItem.Quantity = Convert.ToInt32(txtQuantity.Text.Trim());
                    orderDetailItem.Discount = double.Parse(txtDiscount.Text.Trim());

                    if (!updateOrInsert)
                    {
                        orderDetailRepository.Create(orderDetailItem);

                        orderRepository.UpdateOrderFreight(OrderID);
                        MessageBox.Show("Add order detail successfully.", "Add order detail");
                    }
                    else
                    {
                        var orderDetailDb = orderDetailRepository.GetOrderDetail(OrderID, orderDetailItem.ProductId);
                        orderDetailDb.Quantity = orderDetailItem.Quantity;
                        orderDetailDb.Discount = orderDetailItem.Discount;
                        orderDetailRepository.Update();

                        orderRepository.UpdateOrderFreight(OrderID);
                        MessageBox.Show("Update order detail successfully.", "Update order detail");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, updateOrInsert ? "Update order detail" : "Add order detail") ;
                }
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboProductID_TextChanged(object sender, EventArgs e)
        {
            if (cboProductID.Text != null && cboProductID.Text.Trim() != "")
            {
                int id;
                try
                {
                    id = int.Parse(cboProductID.SelectedValue.ToString());
                }
                catch (Exception)
                {
                    id = -1;
                }

                if (id != -1)
                {
                    var tmpProduct = _productRepository.GetProduct(id);

                    if (tmpProduct != null)
                    {
                        txtUnitPrice.Text = tmpProduct.UnitPrice.ToString();
                    }
                    else
                    {
                        txtUnitPrice.Text = "NOT FOUND";
                    }
                }
            }
        }

        private void cboProductID_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmOrderDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
