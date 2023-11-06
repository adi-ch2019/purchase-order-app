using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace adi.ch.dev.poa.api.Data
{
    public class RegisterVM
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        [Required]
        public required string EmailAddress { get; set; }
        [Required]
        public required string UserName { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}
