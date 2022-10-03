using Login.Commands;
using Login.Models;
using Login.Repository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Handlers
{
    public class AddCustomerHandler : IRequestHandler<AddCustomer, IEnumerable<EcomCustomers>>
    {
        private readonly ICustomerServices _data;
        public AddCustomerHandler(ICustomerServices data)
        {
            _data = data;
        }

        public Task<IEnumerable<EcomCustomers>> Handle(AddCustomer request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.AddCustomers(request.cust));
        }
    }
}

    

