using Domain;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface ITicketRepository
    {
        Task<IQueryable<Ticket>> GetByFilters();
        Task<Ticket> GetById(int id);
        Task Add(Ticket ticket);
        Task Update(Ticket ticket);
        Task Delete(Ticket ticket);
    }
}
