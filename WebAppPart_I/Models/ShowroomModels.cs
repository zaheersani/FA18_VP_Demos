using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace WebAppPart_I.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int? EnginePower { get; set; }
    }

    public class Customer
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }

    public class Order
    {
        public int ID { get; set; }
        // This field will be mapped automatically with ID of Car Class
        public int CarID { get; set; }
        // This field will be mapped automatically with ID of Customer Class
        public int CustomerID { get; set; }

        public int? SalePrice { get; set; }

        // Reference objects need to be created for mapping entire objects with IDs
        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}