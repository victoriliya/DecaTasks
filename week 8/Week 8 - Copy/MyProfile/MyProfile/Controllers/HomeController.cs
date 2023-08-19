using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProfile.Data;
using MyProfile.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProfileRepository _profileRepository;
        private readonly ISkillRepository _skillRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IEventRepository _eventRepository;

        public HomeController(ILogger<HomeController> logger, IProfileRepository profileRepository, ISkillRepository skillRepository, IProjectRepository projectRepository, IEventRepository eventRepository)
        {
            _profileRepository = profileRepository;
            _skillRepository = skillRepository;
            _projectRepository = projectRepository;
            _eventRepository = eventRepository;
            _logger = logger;

        }

        public IActionResult Index()
        {
            var profile = _profileRepository.GetProfile;
            return View(profile);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
