
using Orders.Models;
using System.Collections.Generic;
using System.Linq;

namespace Orders.Repository
{
    public class OrdersServices : IOrdersServices
    {
        private readonly EcomContext _data;



        public OrdersServices(EcomContext data)
        {
            _data = data;
        }
        public IEnumerable<EcomOrders> addOrder(EcomOrders cust)
        {

            _data.EcomOrders.Add(cust);
            _data.SaveChanges();
            return getOrders();
        }

        public EcomOrders getOrdersbyId(int id)
        {
            var usr = _data.EcomOrders.FirstOrDefault(o => o.OrderId == id);
            return usr;
        }

        public IEnumerable<EcomOrders> getOrders()
        {
            return _data.EcomOrders.ToList();
        }


    }

}
