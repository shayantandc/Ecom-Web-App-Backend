using Category.Models;
using MediatR;
using System.Collections.Generic;

namespace Category.Queries
{
    public class GetAllCategoryQuery:IRequest<IEnumerable<EcomCategory>>
    {
    }
}
