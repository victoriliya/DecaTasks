using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{

    public class Profile
    {
        // Profile details
        public Profile()
        {
            List<Project> Projects = new List<Project>();
            List<Skill> Skills = new List<Skill>();
            List<Event> Events = new List<Event>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondtName { get; set; }
        public string OtherName { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string LinkdInLink { get; set; }
        public string GitLink { get; set; }
        public string Bio { get; set; }
        public List<Project> Projects { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Event> Events { get; set; }

    }
}
