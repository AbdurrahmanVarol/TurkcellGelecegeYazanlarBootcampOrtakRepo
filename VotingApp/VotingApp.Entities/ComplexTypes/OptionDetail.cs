using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities.ComplexTypes
{
    public class VoteDetail
    {
        public int NumberOfOption { get; set; }
        public Option Option { get; set; } 
    }
}
