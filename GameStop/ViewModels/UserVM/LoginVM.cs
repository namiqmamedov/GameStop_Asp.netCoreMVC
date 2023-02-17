using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels.UserVM
{
    public class LoginVM
    {
        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(72)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
