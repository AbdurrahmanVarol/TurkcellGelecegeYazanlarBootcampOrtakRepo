using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using VotingApp.Business.Dtos.Requests.PollRequests;
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
        public async Task<IActionResult> ActivePolls()
        {
            var polls = await _pollService.GetActivePolls();
            return View(polls);
        }
        
        [HttpGet]
        public IActionResult CreatedPolls()
        {
            var polls = _pollService.GetPollsByCreatedById(UserId).GetAwaiter().GetResult();
            return View(polls);
        }
    }
}
