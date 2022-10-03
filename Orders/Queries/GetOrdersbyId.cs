
using Orders.Models;
using MediatR;

namespace Orders.Queries
{
    public class GetOrdersbyId : IRequest<EcomOrders>
    {
        public int Id { get; set; }
    }
}
