using Microsoft.AspNetCore.Mvc;
using VotingApp.Business.Requests;

namespace VotingApp.MVC.Controllers
{
    public class PollController : Controller
    {
        
        [HttpGet]
        public IActionResult CreatePoll()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePoll(CreatePollRequest request)
        {
            return View();
        }

        [HttpGet("/activePolls")]
        public IActionResult GetActivePolls()
        {
            return Json(null);
        }
        
        [HttpGet("/joinedPolls")]
        public IActionResult GetJoinedPolls()
        {
            return Json(null);
        }
    }
}
