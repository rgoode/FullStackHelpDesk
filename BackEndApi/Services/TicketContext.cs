using BackEndApi.Models.Ticket;
using BackEndApi.Services.DALModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace BackEndApi.Services
{
    public class TicketContext : DbContext, ITicketContext
    {
        private readonly string _connectionString;

        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Users> Users { get; set; }


        public TicketContext(IOptions<DBConfig> dbConfig)
        {
            _connectionString = dbConfig.Value.Angular;
        }

        public IEnumerable<Tickets> GetTickets()
        {
            return Tickets;
        }

        public Tickets GetTicket(int ticketId)
        {
            var dbTickets = Tickets.Find(ticketId);

            return dbTickets;
        }

        public Tickets DeleteTicket(int ticketId)
        {
            var dbTickets = Tickets.Find(ticketId);

            if (dbTickets != null)
            {
                var entity = Tickets.Remove(dbTickets).Entity;
                SaveChanges();
                return entity;
            }
            return null;
        }

        public Tickets AddTicket(Tickets ticket)
        {
            var ticketEntity = Tickets.Add(ticket).Entity;
            SaveChanges();
            return ticketEntity;
        }

        public Tickets UpdateTicket(Tickets ticket, int ticketID)
        {
            var dbTicket = Tickets.Find(ticketID);
            if (dbTicket != null)
            {
                dbTicket.SubjectLine = ticket.SubjectLine;
                dbTicket.SubmitterName = ticket.SubmitterName;
                dbTicket.SubmitterEmail = ticket.SubmitterEmail;
                dbTicket.Problem = ticket.Problem;

                dbTicket.Solution = ticket.Solution;
                dbTicket.AssignedTo = ticket.AssignedTo;
                dbTicket.Status = ticket.Status;
                dbTicket.Priority = ticket.Priority;

                var entityTicket = Tickets.Update(dbTicket).Entity;
                SaveChanges();
                return entityTicket;
            }
            return null;
        }

        public Users GetUser(int userId)
        {
            var dbUsers = Users.Find(userId);

            return dbUsers;
        }

        public Users DeleteUser(int userId)
        {
            var dbUsers = Users.Find(userId);

            if (dbUsers != null)
            {
                var entity = Users.Remove(dbUsers).Entity;
                SaveChanges();
                return entity;
            }
            return null;
        }

        public Users AddUser(Users users)
        {
            Users userEntity = Users.Add(users).Entity;
            SaveChanges();
            return userEntity;
        }

        public Users UpdateUser(Users users, int userID)
        {
            var dbUsers = Users.Find(userID);
            if (dbUsers != null)
            {
                //have to still what we are updating here

                var entityUsers = Users.Update(dbUsers).Entity;
                SaveChanges();
                return entityUsers;
            }
            return null;
        }

        public IEnumerable<Users> GetUsers()
        {
            return Users;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             //@"Data Source=localhost;Initial Catalog=TicketDB;Integrated Security=True"
             this._connectionString);
        }

    }
}
