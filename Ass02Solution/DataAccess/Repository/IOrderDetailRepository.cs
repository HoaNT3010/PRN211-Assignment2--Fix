using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetails();

        void Update();

        void Create(OrderDetail orderDetail);

        void Delete(int orderId, int productId);

        OrderDetail GetOrderDetail(int orderId, int productId);

        List<OrderDetail> GetOrderDetailsByOrder(int orderId);
    }
}
