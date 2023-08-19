using MyProfile.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class SkillRepository : ISkillRepository
    {

        private readonly MyProfileDbContext myProfileDbContext;
        public SkillRepository(MyProfileDbContext myProfileDbContext)
        {
            _myProfileDbContext = myProfileDbContext;
        }

        public IEnumerable<Skill> GetSkills { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Skill GetSkill(int id)
        {
            return _myProfileDbContext.Skills.Where(x => x.SkillId == id).FirstOrDefault();
        }

        private readonly MyProfileDbContext _myProfileDbContext;

        public bool CreateSkill(Skill skill)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSkill(int skillId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSkill(Skill skill)
        {
            var newSkill = GetSkill(skill.SkillId);
            newSkill.SkillName = skill.SkillName;
            newSkill.SkillShortName = skill.SkillShortName;
            newSkill.SkillCategory = skill.SkillCategory;
            newSkill.SkillDescription = skill.SkillDescription;

            if (_myProfileDbContext.SaveChanges() > 0)
            {
                return true;
            }
            return false;
            
        }
    }
}
