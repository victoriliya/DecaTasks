using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class SkillRepository : ISkillRepository
    {
        public IEnumerable<Skill> GetSkills { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CreateSkill(Skill skill)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSkill(int skillId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSkill(int skillId)
        {
            throw new NotImplementedException();
        }
    }
}
