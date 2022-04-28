using BackEndApi.Models.Ticket;
using System.Collections.Generic;

namespace BackEndApi.Services
{
    public interface ITicketContext : IGetTickets, IGetTicket, IDeleteTicket
    {
    }

    public interface IDeleteTicket
    {
        Tickets DeleteTicket(int ticketId);
    }

    public interface IGetTicket
    {
        Tickets GetTicket(int ticketId);
    }

    public interface IGetTickets
    {
        IEnumerable<Tickets> GetTickets();
    }
}

