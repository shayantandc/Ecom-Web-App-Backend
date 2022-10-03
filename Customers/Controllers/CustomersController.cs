using Customers.Queries;
using Login.Commands;
using Login.Models;
using Login.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediatr;



        public CustomersController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }
        // GET: api/<LoginController>
        [HttpGet("{id}")]
        //[Route("getUsersById")]
        public async Task<EcomCustomers> Get(int id)
        {
            return await _mediatr.Send(new GetCustomersbyId()
            {
                Id = id
            });
        }
        [HttpGet("/GetLogin/{id}")]
        //[Route("getUsersById")]
        public async Task<EcomCustomers> GetbyLogin(int id)
        {
            return await _mediatr.Send(new GetAllCustomersbyLoginid()
            {
                Id = id
            });
        }

        //// GET api/<LoginController>/5
        [HttpGet]
        //[Route("getUsers")]
        public async Task<IEnumerable<EcomCustomers>> getAllCustomers()
        {
            return await _mediatr.Send(new GetAllCustomers());
        }

        // POST api/<LoginController>
        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] EcomCustomers newCust)
        {
            var data = await _mediatr.Send(new AddCustomer() { cust = newCust });
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
