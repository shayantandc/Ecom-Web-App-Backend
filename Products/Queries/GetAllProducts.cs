
using Category.Models;
using MediatR;
using System.Collections.Generic;

namespace Products.Queries
{
    public class GetAllProducts : IRequest<IEnumerable<EcomProducts>>
    {

    }
}

