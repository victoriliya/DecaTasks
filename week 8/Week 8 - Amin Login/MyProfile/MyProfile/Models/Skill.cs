using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class Skill
    {
        // Skill details
        public Skill()
        {
            List<Project> Projects = new List<Project>();
        }
  
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillShortName { get; set; }
        public string SkillCategory { get; set; }
        public string SkillDescription { get; set; }
        public int ProfileId { get; set; }
        public List<Project> Projects { get; set; }

    }
}
