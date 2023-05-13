using Microsoft.AspNetCore.Mvc;
using VotingApp.Business.Requests;
using VotingApp.Business.Services;

namespace VotingApp.MVC.Controllers
{
    public class PollController : Controller
    {
        private readonly IPollService _pollService;

        public PollController(IPollService pollService)
        {
            _pollService = pollService;
        }

        [HttpGet]
        public IActionResult CreatePoll()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePoll([FromBody] CreatePollRequest request)
        {
            var result = _pollService.CreatePollAsync(request).GetAwaiter().GetResult();
            return Json(new { isSuccess = result });
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
