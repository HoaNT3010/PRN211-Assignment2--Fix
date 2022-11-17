using DataAccess.Models;
using DataAccess.Repository;
using SalesWinApp.Normal_User;
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
    public partial class frmReadOrder : Form
    {
        public IOrderRepository _orderRepository;
        public IMemberRepository _memberRepository;
        public IProductRepository _productRepository;
        public IOrderDetailRepository _orderDetailRepository;

        private BindingSource _source;

        public int typeOfOrderPage { get; set; }
        public string tmpEmail { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool isSearched { get; set; }

        public Order Order { get; set; }

        public OrderDetail OrderDetail;

        public frmReadOrder()
        {
            _orderRepository = new OrderRepository();
            _memberRepository = new MemberRepository();
            _productRepository = new ProductRepository();
            _orderDetailRepository = new OrderDetailRepository();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReadOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                if (typeOfOrderPage == 1)
                {
                    frmOrders frmOrders = new()
                    {
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn,
                        tmpEmail = tmpEmail
                    };
                    frmOrders.Show();
                }
                else if (typeOfOrderPage == 2)
                {
                    frmSalesStatistics frmSalesStatistics = new()
                    {
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn,
                        StartDate = StartDate,
                        EndDate = EndDate,
                        tmpEmail = tmpEmail,
                        isSearched = isSearched
                    };
                    frmSalesStatistics.Show();
                }
                else
                {
                    frmUserOrders frmUserOrders = new()
                    {
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn,
                        tmpEmail = tmpEmail
                    };
                    frmUserOrders.Show();
                }
            }
            else
            {
                if (typeOfOrderPage == 1)
                {
                    frmOrders frmOrders = new()
                    {
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn
                    };
                    frmOrders.Show();
                }
                else if (typeOfOrderPage == 2)
                {
                    frmSalesStatistics frmSalesStatistics = new()
                    {
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn,
                        StartDate = StartDate,
                        EndDate = EndDate,
                        isSearched = isSearched
                    };
                    frmSalesStatistics.Show();
                }
                else
                {
                    frmUserOrders frmUserOrders = new()
                    {
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn
                    };
                    frmUserOrders.Show();
                }
            }
        }

        private void txtOrderDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRequiredDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShippedDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFreight_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMemberEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmReadOrder_Load(object sender, EventArgs e)
        {
            var tmpOrder = _orderRepository.GetOrders().FirstOrDefault(c => c.OrderId == Order.OrderId);
            var Member = _memberRepository.GetMembers().FirstOrDefault(c => c.MemberId == Order.MemberId);
            var OrderDetail = _orderDetailRepository.GetOrderDetails().FirstOrDefault(c => c.OrderId == Order.OrderId);
            var Product = _productRepository.GetProducts().FirstOrDefault(c => c.ProductId == OrderDetail.ProductId);
            txtOrderID.Text = Order.OrderId.ToString();
            txtMemberID.Text = Order.MemberId.ToString();
            txtMemberEmail.Text = Member.Email;
            txtOrderDate.Text = Order.OrderDate.ToString();
            txtRequiredDate.Text = Order.RequiredDate.ToString();
            txtShippedDate.Text = Order.ShippedDate.ToString();
            txtFreight.Text = tmpOrder.Freight.ToString();

            _source = new BindingSource();
            _source.DataSource = _orderRepository.GetOrDerDetails(Order.OrderId);

            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = _source;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < (_orderRepository.GetOrders().Count - 1) && e.RowIndex >= 0)
            {
                btnRead.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                CurrentRow = e.RowIndex;
                CurrentColumn = e.ColumnIndex;
                OrderDetail = new OrderDetail();

                OrderDetail.OrderId = int.Parse(dgvOrderDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                OrderDetail.ProductId = int.Parse(dgvOrderDetails.Rows[e.RowIndex].Cells[1].Value.ToString());
                OrderDetail.UnitPrice = decimal.Parse(dgvOrderDetails.Rows[e.RowIndex].Cells[2].Value.ToString());
                OrderDetail.Quantity = int.Parse(dgvOrderDetails.Rows[e.RowIndex].Cells[3].Value.ToString());
                OrderDetail.Discount = double.Parse(dgvOrderDetails.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            else
            {
                btnRead.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

        }
    }
}
