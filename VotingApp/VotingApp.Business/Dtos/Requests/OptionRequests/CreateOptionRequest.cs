using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Business.Dtos.Requests.OptionRequests
{
    public class CreateOptionRequest
    {
        public int? Id { get; set; }
        public int? PollId { get; set; }
        public string Value { get; set; }
    }
}
