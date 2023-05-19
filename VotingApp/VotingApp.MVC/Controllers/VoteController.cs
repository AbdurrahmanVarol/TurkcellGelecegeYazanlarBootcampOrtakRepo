using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Business.Dtos.Requests.VoteRequests;
using VotingApp.Business.Services;
using VotingApp.Entities;

namespace VotingApp.MVC.Controllers
{
    [Authorize]
    public class VoteController : Controller
    {
        private readonly IVoteService _voteService;

        public VoteController(IVoteService voteService)
        {
            _voteService = voteService;
        }

        [HttpPost]
        public async Task<JsonResult> CreateVote(CreateVoteRequest request)
        {
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
