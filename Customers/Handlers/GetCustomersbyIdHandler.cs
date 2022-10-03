using Login.Commands;
using Login.Models;
using Login.Queries;
using Login.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Handlers
{
    public class GetCustomersbyIdHandler : IRequestHandler<GetCustomersbyId, EcomCustomers>
    {
        private readonly ICustomerServices _data;
        public GetCustomersbyIdHandler(ICustomerServices data)
        {
            _data = data;
        }

        public Task<EcomCustomers> Handle(GetCustomersbyId request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getCustomersbyId(request.Id));
        }
    }
}
