using Login.Models;
using MediatR;
using System.Collections.Generic;

namespace Login.Commands
{
    public class AddCustomer:IRequest<IEnumerable<EcomCustomers>>
    {
        public EcomCustomers cust { get; set; }
    }
}
