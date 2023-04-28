using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Options
    {
        public int id{ get; set; }
        public int pollId{ get; set; }
        public int option{ get; set; }
    }
}
