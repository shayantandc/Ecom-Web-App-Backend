using Login.Models;
using System.Collections.Generic;
using System.Linq;

namespace Login.Repository
{
    public class CustomerServices : ICustomerServices
    {
        private readonly EcomContext _data;



        public CustomerServices(EcomContext data)
        {
            _data = data;
        }
        public IEnumerable<EcomCustomers> AddCustomers(EcomCustomers cust)
        {

            _data.EcomCustomers.Add(cust);
            _data.SaveChanges();
            return getCustomers();
        }

        public EcomCustomers getCustomersbyId(int id)
        {
            var usr = _data.EcomCustomers.FirstOrDefault(o => o.CustomerId == id);
            return usr;
        }

        public IEnumerable<EcomCustomers> getCustomers()
        {
            return _data.EcomCustomers.ToList();
        }

        public EcomCustomers getCustomersbyLoginid(int id)
        {
            var usr = _data.EcomCustomers.FirstOrDefault(o => o.LoginId == id);
            return usr;
        }


    }

}
