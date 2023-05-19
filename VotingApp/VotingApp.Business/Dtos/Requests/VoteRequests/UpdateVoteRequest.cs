using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Business.Dtos.Requests.VoteRequests
{
    public class UpdateVoteRequest
    {
        public int Id { get; set; }
        public int OptionId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
