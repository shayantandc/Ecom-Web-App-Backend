using Category.Models;
using Category.Queries;
using Category.Repository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Category.Handlers
{
    public class GetAllCategoryHandler : IRequestHandler<GetAllCategoryQuery, IEnumerable<EcomCategory>>
    {
        private readonly ICategory _data;
        public GetAllCategoryHandler(ICategory data)
        {
            _data = data;
        }
        public async Task<IEnumerable<EcomCategory>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_data.GetAllCategory());
        }
    }
}
