using Application.Common;
using Application.Dtos;
using Application.Exceptions;
using Application.Interfaces;
using Application.QueryFilters;
using Application.Wrappers;
using AutoMapper;
using Domain;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;
        public TicketService(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public async Task<TicketDto> Add(TicketDto ticketDto)
        {
            var ticket = _mapper.Map<Ticket>(ticketDto);
            ticket.CreatedDate = DateTime.Now;
            ticket.UpdatedDate = null;
            ticket.Status = true;

            await _ticketRepository.Add(ticket);
            return _mapper.Map<TicketDto>(ticket);
        }

        public async Task<bool> Delete(int id)
        {
            var ticket = await _ticketRepository.GetById(id);
            if (ticket == null)
            {
                throw new BusinessException(HttpStatusCode.NotFound, "El ticket no existe");
            }

            await _ticketRepository.Delete(ticket);
            return true;
        }

        public async Task<PagedListResponse<TicketDto>> GetTickets(TicketQueryFilter filters)
        {
            var tickets = await _ticketRepository.GetByFilters();

            var pagedListTickets = new PagedListResponse<TicketDto>();

            if (filters.UserId.HasValue)
            {
                tickets = tickets.Where(x => x.User.Id == filters.UserId.Value);
            }

            if (filters.Date.HasValue)
            {
                tickets = tickets.Where(x => x.CreatedDate.Date == filters.Date.Value);
            }

            if (filters.Pagination)
            {
                var pagedTickets = PagedList<Ticket>.Create(tickets.ToList(), filters.PageIndex, filters.ItemsPerPage);
                pagedListTickets = new PagedListResponse<TicketDto>
                {
                    CurrentPage = pagedTickets.CurrentPage,
                    PageSize = pagedTickets.PageSize,
                    TotalCount = pagedTickets.TotalCount,
                    TotalPages = pagedTickets.TotalPages,
                    Items = _mapper.Map<IList<TicketDto>>(pagedTickets)
                };
            }
            else
            {
                pagedListTickets = new PagedListResponse<TicketDto>
                {
                    Items = _mapper.Map<IList<TicketDto>>(tickets.ToList())
                };
            }

            return pagedListTickets;
        }

        public async Task<TicketDto> GetById(int id)
        {
            var ticket = await _ticketRepository.GetById(id);
            return _mapper.Map<TicketDto>(ticket);
        }

        public async Task<TicketDto> Update(TicketDto ticketDto)
        {
            var ticket = await _ticketRepository.GetById(ticketDto.Id);
            if (ticket == null)
            {
                throw new BusinessException(HttpStatusCode.NotFound, "El ticket no existe");
            }

            ticket.UpdatedDate = DateTime.Now;
            ticket.Status = ticketDto.Status;

            await _ticketRepository.Update(ticket);
            return _mapper.Map<TicketDto>(ticket);
        }
    }
}
