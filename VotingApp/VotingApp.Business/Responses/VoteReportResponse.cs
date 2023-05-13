using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities.ComplexTypes;

namespace VotingApp.Business.Responses
{
    public class VoteReportResponse
    {
        public PollResponse Poll { get; set; }
        public List<UserResponse> Participants { get; set; }
        public List<VoteDetail> VoteDetails { get; set; }
    }
}
