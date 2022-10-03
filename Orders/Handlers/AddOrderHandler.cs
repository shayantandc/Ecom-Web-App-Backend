using Orders.Models;
using Orders.Commands;
using Orders.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Orders.Handlers
{
    public class AddOrderHandler : IRequestHandler<AddOrder, IEnumerable<EcomOrders>>
    {
        private readonly IOrdersServices _data;
        public AddOrderHandler(IOrdersServices data)
        {
            _data = data;
        }

        public Task<IEnumerable<EcomOrders>> Handle(AddOrder request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.addOrder(request.ord));
        }
    }
}