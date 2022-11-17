using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {

        public void Create(OrderDetail orderDetail)
        {
            AssSalesContext.Instance.Add(orderDetail);
            AssSalesContext.Instance.SaveChanges();
        }

        public void Delete(int orderId, int productId)
        {
            OrderDetail orderDetail = GetOrderDetail(orderId, productId);
            AssSalesContext.Instance.Remove(orderDetail);
            AssSalesContext.Instance.SaveChanges();
        }

        public OrderDetail GetOrderDetail(int orderId, int productId)
        {
            return AssSalesContext.Instance.OrderDetails.ToList().FirstOrDefault(c => c.OrderId == orderId && c.ProductId == productId);
        }

        public List<OrderDetail> GetOrderDetails() => AssSalesContext.Instance.OrderDetails.ToList();

        public List<OrderDetail> GetOrderDetailsByOrder(int orderId)
        {
            return AssSalesContext.Instance.OrderDetails.Where(x => x.OrderId == orderId).ToList();
        }

        public void Update()
        {
            AssSalesContext.Instance.SaveChanges();
        }
    }
}
