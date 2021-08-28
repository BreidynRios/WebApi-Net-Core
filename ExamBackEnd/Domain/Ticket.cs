namespace Domain
{
    public class Ticket : BaseEntity
    {
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
