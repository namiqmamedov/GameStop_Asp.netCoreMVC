using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels.UserVM
{
    public class ProfileVM
    {
        [StringLength(255),Required]
        public string Name { get; set; }
        [StringLength(255),Required]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(255), Required]
        public string Username { get; set; }

        [StringLength(72)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        public string CurrentPassword { get; set; }

        //[Required]
        [StringLength(72)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        public string Password { get; set; }
        //[Required]
        [StringLength(72)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
