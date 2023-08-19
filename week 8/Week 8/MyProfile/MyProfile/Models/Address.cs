using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class Address
    {
        [Key]
        public string Id { get; set; } = "";

        [StringLength(150)]
        public string  Street { get; set;}

        [StringLength(150)]
        public string City { get; set; }

        [StringLength(150)]
        public string Country { get; set; }
    }
}
