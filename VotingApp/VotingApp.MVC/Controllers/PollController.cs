using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using VotingApp.Business.Requests;
using VotingApp.Business.Services;

namespace VotingApp.MVC.Controllers
{
    public class PollController : Controller
    {
        private readonly IPollService _pollService;
        private int UserId => int.Parse(User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).First().Value);
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
            request.CreatedById = UserId;
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
