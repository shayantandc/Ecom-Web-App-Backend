using Orders.Models;
using Orders.Commands;

using Orders.Queries;
using Orders.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Orders.Handlers
{
    public class GetOrdersbyIdHandler : IRequestHandler<GetOrdersbyId, EcomOrders>
    {
        private readonly IOrdersServices _data;
        public GetOrdersbyIdHandler(IOrdersServices data)
        {
            _data = data;
        }

        public Task<EcomOrders> Handle(GetOrdersbyId request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getOrdersbyId(request.Id));
        }
    }
}