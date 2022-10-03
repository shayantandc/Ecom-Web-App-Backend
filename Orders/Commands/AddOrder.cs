using Orders.Models;
using MediatR;
using System.Collections.Generic;

namespace Orders.Commands
{
    public class AddOrder : IRequest<IEnumerable<EcomOrders>>
    {
        public EcomOrders ord { get; set; }
        
    }
}
