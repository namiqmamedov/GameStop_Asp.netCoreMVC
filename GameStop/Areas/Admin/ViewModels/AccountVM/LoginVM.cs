using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Areas.Admin.ViewModels.AccountVM
{
    public class LoginVM
    {
        [Required]
        [StringLength(255)]

        public string Username { get; set; }
        [Required]
        [StringLength(72)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
