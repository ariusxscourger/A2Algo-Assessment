namespace A2Algo_Assessment.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }

    public class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int QuantitySold { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Product? Product { get; set; }
    }

    public class Purchase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int QuantityPurchased { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Product? Product { get; set; }
    }

}
