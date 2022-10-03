namespace ApiGateway.DTO
{
    public class OrdersDTO
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int OrderQuantity { get; set; }
        public decimal OrderPrice { get; set; }
        public string ShipmentAddress { get; set; }
    }
}