﻿using MyProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.ViewModels
{
    public class EditProfileViewModel
    {
        public Profile Profile { get; set; }
        public ProfileViewModel ProfileViewModel { get; set; }
    }
}
