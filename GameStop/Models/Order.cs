using GameStop.Enums;
using GameStop.ViewModels.Basket;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class Order 
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        [StringLength(255),Required]
        public string Name { get; set; }
        [StringLength(255), Required]
        public string Surname { get; set; }
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mobile no. is required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string Phone { get; set; }
        [StringLength(255), Required]
        public string Address1 { get; set; }
        [StringLength(255), Required]
        public string Address2 { get; set; }
        [StringLength(255), Required]
        public string City { get; set; }
        [DisplayName("Total Price"),Required]
        public double TotalPrice { get; set; }
        [StringLength(255), Required]
        public string State { get; set; }
        [StringLength(255), Required]
        public string ZipCode { get; set; }
        public int AppUserId { get; set; }
        public OrderStatus OrderStatus{ get; set; }
        [NotMapped]
        public List<BasketVM> BasketVMs { get; set; }



        public AppUser AppUser { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }

    }
}
