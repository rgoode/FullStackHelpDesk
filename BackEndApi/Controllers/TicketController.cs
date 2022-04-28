using BackEndApi.Models;
using BackEndApi.Models.Ticket;
using BackEndApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class TicketsController : ControllerBase
    {
        public DbSet<Tickets> Tickets { get; set; }

        private readonly ITicketContext _ticketContext;

        public TicketsController(ITicketContext ticketContext)
        {
            _ticketContext = ticketContext;
        }

        [HttpGet]
        public IActionResult GetAllTickets()
        {
            var students = _ticketContext.GetTickets();

            return Ok(_ticketContext.GetTickets());
        }

        [HttpGet]
        public IActionResult GetTicket(int ticketId)
        {
            var dbTicket = Tickets.Find(ticketId);

            return dbTicket;
        }
    }
}
