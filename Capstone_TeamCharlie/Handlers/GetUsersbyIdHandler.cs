using Login.Commands;
using Login.Models;
using Login.Queries;
using Login.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Handlers
{
    public class GetUsersbyIdHandler : IRequestHandler<GetUsersbyId, EcomLogin>
    {
        private readonly ILogin _data;
        public GetUsersbyIdHandler(ILogin data)
        {
            _data = data;
        }

        public Task<EcomLogin> Handle(GetUsersbyId request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getUsersbyId(request.Mail));
        }
    }
}
