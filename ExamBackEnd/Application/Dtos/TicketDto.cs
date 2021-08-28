using System;

namespace Application.Dtos
{
    public class TicketDto
    {
        public int Id { get; set; }
        public UserDto User { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
