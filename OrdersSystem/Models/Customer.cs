﻿using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace OrdersSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa klienta")]
        public string CustomerName { get; set; }
        [Display(Name = "Kontakt")]
        public string ContactName { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Display(Name = "Kod pocztowy")]
        public string PostalCode { get; set; }
        [Display(Name = "Kraj")]
        public string Country { get; set; }

        public ICollection<Order> Orders { get; } = new List<Order>();
    }
}
