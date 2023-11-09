namespace OrdersSystem.Models
{
    public class Shipper
    {
        public int Id { get; set; }
        public string ShipperName { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; } = new List<Order>();
    }
}
