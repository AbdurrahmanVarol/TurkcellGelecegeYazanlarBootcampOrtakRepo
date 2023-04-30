using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public abstract class Entity
    {
        public Int32 Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
