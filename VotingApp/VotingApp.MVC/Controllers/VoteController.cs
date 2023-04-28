using Microsoft.AspNetCore.Mvc;
using VotingApp.Business.Requests;
using VotingApp.Business.Services;

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

        [HttpGet("getVotesByPollId/{id}")]
        public async Task<JsonResult> GetVotesByPollId(int id)
        {
            var votes = await _voteService.GetVotesByPollIdAsync(id);
            return Json(votes);
        }
        [HttpGet("getVoteReport/{id}")]
        public async Task<JsonResult> GetVoteReportByPollId(int id)
        {
            var votes = await _voteService.GetVoteReportByPollId(id);
            return Json(votes);
        }
    }
}
