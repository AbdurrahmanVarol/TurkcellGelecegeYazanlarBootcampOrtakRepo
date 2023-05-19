using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Business.Dtos.Requests.PollRequests
{
    public class CreatePollRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CreatedById { get; set; }
        public List<string> OptionNames { get; set; }
    }
}
