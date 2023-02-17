 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels.UserVM
{
    public class RegisterVM
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Surname { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; }
        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(72)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        public string Password { get; set; }
        [Required]
        [StringLength(72)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
