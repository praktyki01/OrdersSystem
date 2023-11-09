namespace OrdersSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; } = null!;

        public int ShipperId { get; set; }
        public Shipper? Shipper { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get;} = new List<OrderDetail>();
    }
}
