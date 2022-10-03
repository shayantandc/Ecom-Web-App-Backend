using Customers.Queries;
using Login.Commands;
using Login.Models;
using Login.Queries;
using Login.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Customers.Handlers
{
    public class GetAllCustomersbyLoginidHandler : IRequestHandler<GetAllCustomersbyLoginid, EcomCustomers>
    {
        private readonly ICustomerServices _data;
        public GetAllCustomersbyLoginidHandler(ICustomerServices data)
        {
            _data = data;
        }

        public Task<EcomCustomers> Handle(GetAllCustomersbyLoginid request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getCustomersbyLoginid(request.Id));
        }
    }
    
}
