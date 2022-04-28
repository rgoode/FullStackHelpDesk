using BackEndApi.Models.Ticket;
using BackEndApi.Services.DALModels;
using Microsoft.EntityFrameworkCore;

namespace BackEndApi.Services
{
    public class TicketContext : DbContext, ITicketContext
    {
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Users> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             @"Data Source=localhost;Initial Catalog=TicketDB;Integrated Security=True");
        }

    }   
}
