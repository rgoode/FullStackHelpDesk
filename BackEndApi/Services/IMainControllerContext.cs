using BackEndApi.Models.Ticket;
using BackEndApi.Services.DALModels;
using System.Collections.Generic;

namespace BackEndApi.Services
{
    public interface IMainControllerContext : IGetUsers, IGetUser, IDeleteUser, IAddUser, IUpdateUser, IGetTickets, IGetTicket, IDeleteTicket, IAddTicket, IUpdateTicket
    {
    }

    public interface IAddUser 
    {
        Users AddUser(Users users);
    }

    public interface IDeleteUser
    {
        Users DeleteUser(int userId);
    }

    public interface IGetUser
    {
        Users GetUser(int userId);
    }

    public interface IUpdateUser
    {
        Users UpdateUser(Users users, int userID);
    }

    public interface IGetUsers
    {
        IEnumerable<Users> GetUsers();
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
