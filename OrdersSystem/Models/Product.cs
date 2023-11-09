namespace OrdersSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }

        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category? Category { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
    }
}
