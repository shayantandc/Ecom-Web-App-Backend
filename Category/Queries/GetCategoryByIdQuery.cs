using Category.Models;
using MediatR;

namespace Category.Queries
{
    public class GetCategoryByIdQuery:IRequest<EcomCategory>
    {
        public int CategoryId { get; set; }
    }
}
