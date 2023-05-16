using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using VotingApp.Business.Requests;
using VotingApp.Business.Services;

namespace VotingApp.MVC.Controllers
{
    [Authorize]
    public class PollController : Controller
    {
        private readonly IPollService _pollService;
        private int UserId => int.Parse(User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
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

        [HttpGet]
        public IActionResult ActivePolls()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult CreatedPolls()
        {
            return View();
        }
    }
}
