using Microsoft.AspNetCore.Mvc;
using VotingApp.Business.Requests;
using VotingApp.Business.Services;
using VotingApp.Entities;

namespace VotingApp.MVC.Controllers
{
    public class VoteController : Controller
    {
        private readonly IVoteService _voteService;

        public VoteController(IVoteService voteService)
        {
            _voteService = voteService;
        }

        [HttpPost("createVote")]
        public async Task<JsonResult> CreateVote(CreateVoteRequest request)
        {
            var vote = await _voteService.AddAsync(request);
            return Json(vote);
        }

        [HttpGet("getVoteReport/{id}")]
        public async Task<JsonResult> GetVoteReportByPollId(int id)
        {
            var result = await _voteService.GetVoteReportByPollId(id);
            return Json(result);
        }
    }
}
