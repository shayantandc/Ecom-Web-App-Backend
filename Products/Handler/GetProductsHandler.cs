
using Products.Queries;
using Products.Repository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Category.Models;

namespace Products.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetAllProducts, IEnumerable<EcomProducts>>
    {
        private readonly IProductServices _data;
        public GetProductsHandler(IProductServices data)
        {
            _data = data;
        }

        public Task<IEnumerable<EcomProducts>> Handle(GetAllProducts request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getProducts());
        }
    }
}