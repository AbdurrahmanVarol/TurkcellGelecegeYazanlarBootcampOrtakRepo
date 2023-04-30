using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Poll : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public ICollection<Option> Options { get; set; } = new List<Option>();
    }
}
