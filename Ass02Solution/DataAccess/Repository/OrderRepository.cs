using AutoMapper.Execution;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {

        public void Create(Order order)
        {
            AssSalesContext.Instance.Add(order);
            AssSalesContext.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Order order = GetOrder(id);
            AssSalesContext.Instance.Remove(order);
            AssSalesContext.Instance.SaveChanges();
        }

        public Order GetOrder(int id)
        {
            return AssSalesContext.Instance.Orders.ToList().FirstOrDefault(c => c.OrderId == id);
        }

        public List<Order> GetOrders() => AssSalesContext.Instance.Orders.ToList();

        public void Update()
        {
            AssSalesContext.Instance.SaveChanges();
        }

        public void UpdateOrderFreight(int orderId)
        {
            var orderDetails = AssSalesContext.Instance.OrderDetails.Where(x => x.OrderId == orderId).ToList();
            decimal newOrderFreight = 0;
            foreach (var orderDetail in orderDetails) {
                decimal discount = (decimal)orderDetail.Discount * (orderDetail.UnitPrice * orderDetail.Quantity);
                decimal totalPrice = decimal.Subtract(orderDetail.UnitPrice * orderDetail.Quantity, discount);
                newOrderFreight += totalPrice;
            }
            var order = GetOrder(orderId);
            order.Freight = newOrderFreight;
            AssSalesContext.Instance.SaveChanges();
        }
    }
}
