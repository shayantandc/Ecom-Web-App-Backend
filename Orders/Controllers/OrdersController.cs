using Orders.Models;
using Orders.Commands;

using Orders.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediatr;



        public OrdersController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }
        // GET: api/<LoginController>
        [HttpGet("{id}")]
        //[Route("getUsersById")]
        public async Task<EcomOrders> Get(int id)
        {
            return await _mediatr.Send(new GetOrdersbyId()
            {
                Id = id
            });
        }

        //// GET api/<LoginController>/5
        [HttpGet]
        //[Route("getUsers")]
        public async Task<IEnumerable<EcomOrders>> getAllCustomers()
        {
            return await _mediatr.Send(new GetAllOrders());
        }

        // POST api/<LoginController>
        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody] EcomOrders newCust)
        {
            var data = await _mediatr.Send(new AddOrder() { ord = newCust });
            return Ok(data);

        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

