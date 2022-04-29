using BackEndApi.Models;
using BackEndApi.Models.Ticket;
using BackEndApi.Services;
using BackEndApi.Services.Models;
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
        [Route("{TicketID}")]
        public IActionResult GetTicket([FromRoute] int ticketId)
        {
            var ticket = _ticketContext.GetTicket(ticketId);
            if (ticket != null)
            {
                return Ok(ticket);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{TicketID}")]
        public IActionResult DeleteTicket([FromRoute] int ticketId)
        {
            var ticket = _ticketContext.DeleteTicket(ticketId);
            if (ticket == null)
            {
                return NotFound();
            }
            return Accepted();
        }

        [HttpPost]
        public IActionResult AddTicket([FromBody] PostTicketRequest postTicketRequest)
        {
            var ticket = new Tickets();

            ticket.SubjectLine = postTicketRequest.RequestTitle;
            ticket.SubmitterEmail = postTicketRequest.SubmitterEmail;
            ticket.SubmittedTime = System.DateTime.UtcNow;
            ticket.Problem = postTicketRequest.Problem;

            ticket.AssignedTo = null;
            ticket.Priority = 4;
            ticket.Status = "In Progress";
            ticket.Solution = null;

            var dbTicket = _ticketContext.AddTicket(ticket);

            return Created("I made you", dbTicket);
        }
    }
}
