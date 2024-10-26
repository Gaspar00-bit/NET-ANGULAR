namespace MarketplaceApi.Modelos
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime Data { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }

        public User User { get; set; }
    }
}
