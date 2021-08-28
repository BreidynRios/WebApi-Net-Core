using System.Collections.Generic;

namespace Domain
{
    public class User : BaseEntity
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
