using Login.Models;
using MediatR;

namespace Customers.Queries
{
    public class GetAllCustomersbyLoginid : IRequest<EcomCustomers>
    {
        public int Id { get; set; }
    }
}
