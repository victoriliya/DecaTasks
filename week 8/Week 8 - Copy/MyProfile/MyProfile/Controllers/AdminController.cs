using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProfileRepository _profileRepository;

        public AdminController(ILogger<HomeController> logger, IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
            _logger = logger;

        }

        public IActionResult Index()
        {
            var profile = _profileRepository.GetProfile;
            return View(profile);
        }
    }
}
