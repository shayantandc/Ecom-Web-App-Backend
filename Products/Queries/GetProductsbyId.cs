
using Category.Models;
using MediatR;

namespace Products.Queries
{
    public class GetProductsbyId : IRequest<EcomProducts>
    {
        public int Id { get; set; }
    }
}
