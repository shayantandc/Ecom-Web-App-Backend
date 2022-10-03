using Login.Models;
using Login.Queries;
using Login.Repository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Handlers
{
    public class GetCustomersHandler : IRequestHandler<GetAllCustomers, IEnumerable<EcomCustomers>>
    {
        private readonly ICustomerServices _data;
        public GetCustomersHandler(ICustomerServices data)
        {
            _data = data;
        }

        public Task<IEnumerable<EcomCustomers>> Handle(GetAllCustomers request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getCustomers());
        }
    }
}
