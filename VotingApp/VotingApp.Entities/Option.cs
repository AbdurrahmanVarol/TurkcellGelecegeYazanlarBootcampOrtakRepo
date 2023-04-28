using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Option : Entity
    {
        public string Value { get; set; }

        public int PollId { get; set; }
        public Poll Poll { get; set; }
    }
}
