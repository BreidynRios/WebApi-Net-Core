using System;

namespace Application.QueryFilters
{
    public class TicketQueryFilter: PageFilter
    {
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }
    }
}
