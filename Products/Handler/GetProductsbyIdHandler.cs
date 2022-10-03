using Products.Commands;
using Products.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Category.Models;
using Products.Queries;

namespace Products.Handlers
{
    public class GetProductsbyIdHandler : IRequestHandler<GetProductsbyId, EcomProducts>
    {
        private readonly IProductServices _data;
        public GetProductsbyIdHandler(IProductServices data)
        {
            _data = data;
        }

        public Task<EcomProducts> Handle(GetProductsbyId request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.getProductsbyId(request.Id));
        }
    }
}
