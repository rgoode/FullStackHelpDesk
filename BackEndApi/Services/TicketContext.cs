using BackEndApi.Models.Ticket;
using Microsoft.EntityFrameworkCore;

namespace BackEndApi.Services
{
    public class TicketContext : DbContext, ITicketContext
    {
        public DbSet<OpenTicket> OpenTickets { get; set; }
        public DbSet<ClosedTicket> ClosedTickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             @"Data Source=localhost;Initial Catalog=MovieDb;Integrated Security=True");
        }

    }   
}
