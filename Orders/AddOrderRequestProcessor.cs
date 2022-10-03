using Orders.Commands;
using Orders.Models;
using Orders.Repository;
using System;

namespace Orders
{
    public class AddOrderRequestProcessor
    {
        private readonly IOrdersServices _addorderRepositoryMock;

        public AddOrderRequestProcessor(IOrdersServices _addorderRepository)
        {
            _addorderRepositoryMock = _addorderRepository;
        }

        public AddOrderResponse Add(AddOrderRequest request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            //_addorderRepositoryMock.Save(Create<AddOrder>(request));

            return Create<AddOrderResponse>(request);
        }

        private static T Create<T>(AddOrderRequest request) where T : EcomOrders, new()
        {
            return new T
            {
                OrderId = request.OrderId,

            };
        }
    }
}

