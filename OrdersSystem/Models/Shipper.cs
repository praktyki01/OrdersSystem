using System.ComponentModel.DataAnnotations;

namespace OrdersSystem.Models
{
    public class Shipper
    {
        public int Id { get; set; }
        [Display(Name = "Firma kurierska")]
        public string ShipperName { get; set; }
        [Display(Name = "Numer telefonu")]
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; } = new List<Order>();
    }
}
