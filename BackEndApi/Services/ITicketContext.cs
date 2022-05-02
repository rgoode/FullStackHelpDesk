using BackEndApi.Models.Ticket;
using System.Collections.Generic;

namespace BackEndApi.Services
{
    public interface ITicketContext : IGetTickets, IGetTicket, IDeleteTicket, IAddTicket, IUpdateTicket
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

    public interface IAddTicket
    {
        Tickets AddTicket(Tickets ticket);
    }

    public interface IUpdateTicket
    {
        Tickets UpdateTicket(Tickets ticket, int ticketID);
    }
}

