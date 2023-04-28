using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Poll : Entity
    {
        public string Title{ get; set; }
        public string Description { get; set; }

        public int CreatedBy { get; set; }
        public User User{ get; set; }

        public ICollection<Option> Options{ get; set;}
    }
}
