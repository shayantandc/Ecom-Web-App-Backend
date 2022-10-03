using System;



namespace ApiGateway.DTO
{
    public class PaymentDTO
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string PaymentMode { get; set; }
        public string CardNumber { get; set; }
        public int? CardCvv { get; set; }
        public DateTime? CardExpiry { get; set; }
        public string CardName { get; set; }
    }
}
