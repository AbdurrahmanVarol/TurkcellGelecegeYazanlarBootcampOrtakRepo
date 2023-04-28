using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Polls
    {
        public int id{ get; set; }
        public string title{ get; set; }
        public string description { get; set; }
        public DateTime createdAt { get; set; }
        public int createdBy { get; set; }
    }
}
