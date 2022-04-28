using BackEndApi.Models.Ticket;
using BackEndApi.Services.DALModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BackEndApi.Services
{
    public class TicketContext : DbContext, ITicketContext, IDeleteTicket
    {
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Users> Users { get; set; }

        public IEnumerable<Tickets> GetTickets()
        {
            return Tickets;
        }

        public Tickets GetTicket(int ticketId)
        {
            var dbTickets= Tickets.Find(ticketId);

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






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             @"Data Source=localhost;Initial Catalog=TicketDB;Integrated Security=True");
        }

    }   
}
