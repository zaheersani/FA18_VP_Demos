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
        
        [Range(650, 3000)]
        public int? EnginePower { get; set; }
    }

    public class SignUp
    {
        public int ID { get; set; }

        [MinLength(6)]
        [MaxLength(10)]
        [Required]
        public string UserName { get; set; }

        [MinLength(6)]
        [MaxLength(12)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Range(18, 30, ErrorMessage="You do not qualify for this")]
        public int Age { get; set; }
    }

    public class Customer
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Please Enter Your Name!")]
        [Display(Name="Customer Name")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage="Please Enter Valid E-mail")]
        public string Email { get; set; }
    }

    public class Order
    {
        public int ID { get; set; }
        // This field will be mapped automatically with ID of Car Class
        [Display(Name="Car")]
        public int CarID { get; set; }
        // This field will be mapped automatically with ID of Customer Class
        [Display(Name = "Customer")]
        public int CustomerID { get; set; }

        public int? SalePrice { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat]
        public DateTime? PurchasedOn { get; set; }

        // Reference objects need to be created for mapping entire objects with IDs
        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}