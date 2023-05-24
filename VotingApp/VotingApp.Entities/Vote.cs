using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Vote : Entity
    {
        public int OptionId { get; set; }
        public Option Option { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
