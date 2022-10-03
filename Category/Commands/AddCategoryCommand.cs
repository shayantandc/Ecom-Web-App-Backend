using Category.Models;
using MediatR;
using System.Collections.Generic;

namespace Category.Commands
{
    public class AddCategoryCommand:IRequest<IEnumerable<EcomCategory>>
    {
        public EcomCategory CategoryName { get; set; }
    }
}
