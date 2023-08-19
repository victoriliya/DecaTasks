using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class Project
    {
        // projects details
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCategory { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectSnapShop { get; set; }
        public string ProjectLink { get; set; }
        public string ProjectGitReposiory { get; set; }
        public string ProjectDemoVideoLink { get; set; }
        public string ProjectStartDate { get; set; }
        public int SkillId { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public Skill Skill { get; set; }
        
    }
}
