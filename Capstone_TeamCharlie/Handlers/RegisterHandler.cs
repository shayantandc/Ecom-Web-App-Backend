using Login.Commands;
using Login.Models;
using Login.Repository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Handlers
{
    public class RegisterHandler : IRequestHandler<Register, EcomLogin>
    {
        private readonly ILogin _data;
        public RegisterHandler(ILogin data)
        {
            _data = data;
        }

        public Task<EcomLogin> Handle(Register request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.register(request.logi));
        }
    }
}

    

