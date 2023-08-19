using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class Admin : IdentityUser
    {
        [StringLength(35)]
        public string FirstName { get; set; }

        [StringLength(35)]
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string AddressId { get; set; }

    }
}
