using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace adi.ch.dev.poa.api.Data
{
    public class LoginVM
    {
        [Required]
        public required string EmailAddress { get; set; }
        
        [Required]
        public required string Password { get; set; }
    }
}
