using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Repository.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly DBExamContext _context;
        public TicketRepository(DBExamContext context)
        {
            _context = context;
        }

        public async Task Add(Ticket ticket)
        {
            await _context.AddAsync(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Ticket ticket)
        {
            _context.Remove(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task<IQueryable<Ticket>> GetByFilters()
        {
            var tickets = _context.Tickets
                                    .Include(x => x.User).AsQueryable();
            return tickets;
        }

        public async Task<Ticket> GetById(int id)
        {
            var ticket = await _context.Tickets
                                    .Include(x => x.User).FirstOrDefaultAsync(x => x.Id == id);
            return ticket;
        }

        public async Task Update(Ticket ticket)
        {
            _context.Update(ticket);
            await _context.SaveChangesAsync();
        }
    }
}
