
using Category.Models;
using MediatR;
using System.Collections.Generic;

namespace Products.Commands
{
    public class AddProduct : IRequest<IEnumerable<EcomProducts>>
    {
        public EcomProducts prod { get; set; }
        

    }
}
