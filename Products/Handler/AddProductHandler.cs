using Products.Commands;
using Products.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Category.Models;
using System.Collections.Generic;

namespace Products.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProduct, IEnumerable<EcomProducts>>
    {
        private readonly IProductServices _data;
        public AddProductHandler(IProductServices data)
        {
            _data = data;
        }

        public Task<IEnumerable<EcomProducts>> Handle(AddProduct request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.addProduct(request.prod));
        }
    }
}

