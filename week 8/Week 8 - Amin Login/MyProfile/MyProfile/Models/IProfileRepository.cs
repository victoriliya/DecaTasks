using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{

    /// <summary>
    /// Interface to define contracts for profile operations
    /// </summary>
    public interface IProfileRepository
    {
        Profile GetProfile { get; }

        bool CreateProfile(Profile profile);
        bool UpdateProfile(int profileId);
        bool DeleteProfile(int profileId);
       
    }
}
