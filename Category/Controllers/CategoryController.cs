using Category.Commands;
using Category.Logger;
using Category.Models;
using Category.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Category.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IMediator _mediator;
        //private IloggerService _loggerService;

        public CategoryController (IMediator mediator)
        {
            _mediator = mediator;
           // _loggerService= loggerService;
        }
        [HttpGet]
        //[Route("getUsers")]
        public async Task<IEnumerable<EcomCategory>> getAllUsers()
        {
            //_loggerService.LogInfo("Fetching all Categories");
            return await _mediator.Send(new GetAllCategoryQuery());
        }
        [HttpGet("{id}")]
        //[Route("getUsersById")]
        public async Task<EcomCategory> Get(int id)
        {
            return await _mediator.Send(new GetCategoryByIdQuery()
            {
                CategoryId = id
            });
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] EcomCategory newCategory)
        {
            var data = await _mediator.Send(new AddCategoryCommand() { CategoryName = newCategory });
            return Ok(data);

        }

    }
}
