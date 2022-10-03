using Login.Models;
using MediatR;
using System.Collections.Generic;

namespace Login.Queries
{
    public class GetAllCustomers:IRequest<IEnumerable<EcomCustomers>>
    {

    }
}
