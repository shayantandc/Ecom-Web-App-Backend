
using Orders.Models;
using MediatR;
using System.Collections.Generic;

namespace Orders.Queries
{
    public class GetAllOrders : IRequest<IEnumerable<EcomOrders>>
    {

    }
}