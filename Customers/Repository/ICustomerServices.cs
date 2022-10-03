using Login.Models;
using System.Collections.Generic;

namespace Login.Repository
{
    public interface ICustomerServices
    {
        public IEnumerable<EcomCustomers> AddCustomers(EcomCustomers cust);
        public EcomCustomers getCustomersbyId(int id);
        public IEnumerable<EcomCustomers> getCustomers();
        public EcomCustomers getCustomersbyLoginid(int id);

    }
}
