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

namespace SalesWinApp.Normal_User.User_Orders
{
    public partial class frmReadOrderMember : Form
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
        public frmReadOrderMember()
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

        private void frmReadOrderMember_Load(object sender, EventArgs e)
        {
            var tmpOrder = _orderRepository.GetOrders().FirstOrDefault(c => c.OrderId == Order.OrderId);
            var Member = _memberRepository.GetMembers().FirstOrDefault(c => c.MemberId == Order.MemberId);
            var OrderDetail = _orderDetailRepository.GetOrderDetails().FirstOrDefault(c => c.OrderId == Order.OrderId);
            if(OrderDetail != null)
            {
                var Product = _productRepository.GetProducts().FirstOrDefault(c => c.ProductId == OrderDetail.ProductId);
            }
            
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

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < (_orderRepository.GetOrder(Order.OrderId).OrderDetails.Count) && e.RowIndex >= 0)
            {
                btnRead.Enabled = true;
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
            }
        }

        private void frmReadOrderMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmUserOrders frmUserOrders = new() { tmpEmail = tmpEmail };
            frmUserOrders.Show();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            frmOrderDetailMember frmOrderDetail = new frmOrderDetailMember()
            {
                OrderDetail = OrderDetail
            };
            frmOrderDetail.Show();
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
