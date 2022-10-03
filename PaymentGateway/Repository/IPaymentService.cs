using Category.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PaymentGateway.Repository
{
    public interface IPaymentService
    {
            Task<IEnumerable<EcomPayment>> AddPayment(EcomPayment payment);
            
        

    }
}
