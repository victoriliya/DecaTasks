using Microsoft.EntityFrameworkCore;
using MyProfile.Data;
using MyProfile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly MyProfileDbContext _myProfileDbContext;      

        public ProfileRepository(MyProfileDbContext myProfileDbContext)
        {
            _myProfileDbContext = myProfileDbContext;
        }

        public Profile GetProfile
        {
            get{
                return _myProfileDbContext.Profile.Include(x => x.Projects).Include(x => x.Skills).ThenInclude(x => x.Projects).Include(x => x.Events).Include(x => x.Events).FirstOrDefault();
            }
        }

        public bool CreateProfile(Profile profile)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProfile(int profileId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProfile(Profile newProfile)
        {
            
            var profile = GetProfile;
            profile.FirstName = newProfile.FirstName;
            profile.SecondtName = newProfile.SecondtName;
            profile.OtherName = newProfile.OtherName;
            profile.Email = newProfile.Email;
            profile.DateOfBirth = newProfile.DateOfBirth;
            profile.ProfilePictureUrl = newProfile.ProfilePictureUrl;
            profile.FacebookLink = newProfile.FacebookLink;
            profile.TwitterLink = newProfile.TwitterLink;
            profile.LinkdInLink = newProfile.LinkdInLink;
            profile.GitLink = newProfile.GitLink;
            profile.Bio = newProfile.Bio;


            if (_myProfileDbContext.SaveChanges() > 0)
            {
                return true;
            }
            return false;

        }
    }
}
