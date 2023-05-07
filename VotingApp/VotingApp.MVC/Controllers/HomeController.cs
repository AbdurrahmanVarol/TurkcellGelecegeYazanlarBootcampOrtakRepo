using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VotingApp.Business.Services;
using VotingApp.MVC.Models;

namespace VotingApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPollService _pollService;

        public HomeController(IPollService pollService)
        {
            _pollService = pollService;
        }

        public IActionResult Index()
        {
            var userId = 1;
            var joinedPolls = _pollService.GetJoinedPolls(userId).GetAwaiter().GetResult();
            return View(joinedPolls);
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