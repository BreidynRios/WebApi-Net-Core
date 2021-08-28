using Application.Dtos;
using Application.QueryFilters;
using Application.Wrappers;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITicketService
    {
        Task<PagedListResponse<TicketDto>> GetTickets(TicketQueryFilter filters);
        Task<TicketDto> GetById(int id);
        Task<TicketDto> Add(TicketDto ticketDto);
        Task<TicketDto> Update(TicketDto ticketDto);
        Task<bool> Delete(int id);
    }
}
