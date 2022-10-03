
using Orders.Models;
using Orders.Queries;
using Orders.Repository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Orders.Handlers
{
    public class GetOrdersHandler : IRequestHandler<GetAllOrders, IEnumerable<EcomOrders>>
    {
        private readonly IOrdersServices _data;
        public GetOrdersHandler(IOrdersServices data)
        {
            _data = data;
        }

        public Task<IEnumerable<EcomOrders>> Handle(GetAllOrders request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getOrders());
        }
    }
}