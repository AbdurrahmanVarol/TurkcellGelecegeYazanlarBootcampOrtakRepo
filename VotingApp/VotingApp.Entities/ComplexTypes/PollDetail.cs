using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities.ComplexTypes
{
    public class PollDetail
    {
        public Poll Poll { get; set; }
        public int NumberOfParticipant { get; set; }
    }
}
