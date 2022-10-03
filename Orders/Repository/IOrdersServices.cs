
using Orders.Models;
using System.Collections.Generic;

namespace Orders.Repository
{
    public interface IOrdersServices
    {
        public IEnumerable<EcomOrders> addOrder(EcomOrders cust);
        public EcomOrders getOrdersbyId(int id);
        public IEnumerable<EcomOrders> getOrders();

    }
}
