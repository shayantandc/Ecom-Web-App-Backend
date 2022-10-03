using Login.Models;
using MediatR;
using System.Collections.Generic;

namespace Login.Commands
{
    public class Register : IRequest<EcomLogin>
    {
        public EcomLogin logi { get; set; }
    }
}
