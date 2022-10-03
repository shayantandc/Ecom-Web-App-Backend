using Category.Models;
using MediatR;
using PaymentGateway.Commands;
using PaymentGateway.Repository;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PaymentGateway.Handlers
{
    public class AddPaymentHandler : IRequestHandler<AddPaymentCommand, IEnumerable<EcomPayment>>
    {
        private readonly IPaymentService _paymentService;

        public AddPaymentHandler(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public async Task<IEnumerable<EcomPayment>> Handle(AddPaymentCommand request, CancellationToken cancellationToken)
        {
            return await _paymentService.AddPayment(request.Payment);
        }
    }
}




