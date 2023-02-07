using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class Setting : BaseEntity
    { 

        public string Key { get; set; }
        [StringLength(2500)]

        public string Value { get; set; }
    }
}
