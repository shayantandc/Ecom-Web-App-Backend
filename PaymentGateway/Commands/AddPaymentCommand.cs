using Category.Models;
using MediatR;
using System.Collections.Generic;

namespace PaymentGateway.Commands
{
    public class AddPaymentCommand : IRequest<IEnumerable<EcomPayment>>
    {
        public EcomPayment Payment { get; set; }
    }
}


