using Category.Commands;
using Category.Models;
using Category.Repository;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Category.Handlers
{
    public class AddCategoryHandler : IRequestHandler<AddCategoryCommand, IEnumerable<EcomCategory>>
    {
        private readonly ICategory _data;
        public AddCategoryHandler(ICategory data)
        {
            _data = data;
        }

        public Task<IEnumerable<EcomCategory>> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.AddCategory(request.CategoryName));
        }
    }
}
