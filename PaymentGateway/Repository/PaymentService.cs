using Category.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGateway.Repository
{
    public class PaymentService:IPaymentService
    {
        private readonly EcomContext _db;

        public PaymentService(EcomContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<EcomPayment>> GetAll()
        {
            return await Task.FromResult(_db.EcomPayment.ToList());
        }

        public async Task<IEnumerable<EcomPayment>> AddPayment(EcomPayment payment)
        {
            _db.EcomPayment.Add(payment);
            await _db.SaveChangesAsync();
            return await GetAll();
        }

        

    }
}
