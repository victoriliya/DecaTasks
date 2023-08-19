using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{

    /// <summary>
    /// Interface to define contracts for skill operation
    /// </summary>
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetSkills { get; set; }
        public bool CreateSkill(Skill skill);
        public bool UpdateSkill(int skillId);
        public bool DeleteSkill(int skillId);
 
        
    }
}
