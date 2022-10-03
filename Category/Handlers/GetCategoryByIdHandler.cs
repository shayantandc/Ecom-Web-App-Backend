using Category.Models;
using Category.Queries;
using Category.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Category.Handlers
{
    public class GetAllCategoryByIdHandler : IRequestHandler<GetCategoryByIdQuery, EcomCategory>
    {

        private readonly ICategory _data;
        public GetAllCategoryByIdHandler(ICategory data)
        {
            _data = data;
        }

        public async Task<EcomCategory> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_data.getCategoryById(request.CategoryId));
        }
    }
}
