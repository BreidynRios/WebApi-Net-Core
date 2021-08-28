using Application.Dtos;
using Application.Interfaces;
using Application.QueryFilters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTickets([FromQuery]TicketQueryFilter filters)
        {
            var tickets = await _ticketService.GetTickets(filters);
            return Ok(tickets);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ticket = await _ticketService.GetById(id);
            return Ok(ticket);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TicketDto ticketDto)
        {
            var result = await _ticketService.Add(ticketDto);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, TicketDto ticketDto)
        {
            ticketDto.Id = id;
            var result = await _ticketService.Update(ticketDto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _ticketService.Delete(id);
            return Ok(result);
        }
    }
}
