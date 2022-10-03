using Login.Models;
using MediatR;

namespace Login.Queries
{
    public class GetCustomersbyId:IRequest<EcomCustomers>
    {
        public int Id { get; set; }
    }
}
