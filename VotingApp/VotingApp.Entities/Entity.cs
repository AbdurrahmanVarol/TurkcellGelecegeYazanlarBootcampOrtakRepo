using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public abstract class Entity : ISoftDeletable,IMappable
    {
        public Int32 Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Boolean IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
