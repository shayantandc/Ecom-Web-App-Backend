using Login.Models;
using MediatR;
using System.Collections.Generic;

namespace Login.Queries
{
    public class GetAllUsers:IRequest<IEnumerable<EcomLogin>>
    {

    }
}
