using Login.Models;
using Login.Queries;
using Login.Repository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Handlers
{
    public class GetUsersHandler : IRequestHandler<GetAllUsers, IEnumerable<EcomLogin>>
    {
        private readonly ILogin _data;
        public GetUsersHandler(ILogin data)
        {
            _data = data;
        }
        public Task<IEnumerable<EcomLogin>> Handle(GetAllUsers request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getUsers());
        }
    }
}
