using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Votes
    {
        public int id{ get; set; }
        public int userId{ get; set; }
        public int optionId { get; set; }
    }
}
