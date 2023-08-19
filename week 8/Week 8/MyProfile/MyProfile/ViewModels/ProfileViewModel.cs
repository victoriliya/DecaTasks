using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.ViewModels
{
    public class ProfileViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
  
        public string OtherName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public string ProfilePictureUrl { get; set; }
        [Required]
        public string FacebookLink { get; set; }
        [Required]
        public string TwitterLink { get; set; }
        [Required]
        public string LinkdInLink { get; set; }
        [Required]
        public string GitLink { get; set; }
        [Required]
        public string Bio { get; set; }
    }
}
