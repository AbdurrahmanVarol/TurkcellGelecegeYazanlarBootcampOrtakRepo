using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using VotingApp.Business.Dtos.Requests.VoteRequests;
using VotingApp.Business.Services;
using VotingApp.Entities;

namespace VotingApp.MVC.Controllers
{
    [Authorize]
    public class VoteController : Controller
    {
        private readonly IVoteService _voteService;
        private int UserId => int.Parse(User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);

        public VoteController(IVoteService voteService)
        {
            _voteService = voteService;
        }

        [HttpPost]
        public async Task<JsonResult> CreateVote([FromBody] CreateVoteRequest request)
        {
            request.UserId = UserId;
            var vote = await _voteService.AddAsync(request);
            return Json(vote);
        }

        [HttpGet("[controller]/getVoteReport/{id}")]
        public async Task<JsonResult> GetVoteReport(int id)
        {
            var result = await _voteService.GetVoteReportByPollId(id);
            return Json(result);
        }
    }
}
