using Category.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentGateway.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PaymentGateway.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentController(IMediator mediator)
        {
            _mediator = mediator;
        }

  

        [HttpPost]
        public async Task<IEnumerable<EcomPayment>> AddPayment([FromBody] EcomPayment payment)
        {
            return await _mediator.Send(new AddPaymentCommand() { Payment = payment });
        }

    }
}
