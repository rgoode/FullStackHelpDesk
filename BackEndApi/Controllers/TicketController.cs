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
        private readonly ITicketContext _ticketContext;

        public TicketsController(ITicketContext ticketContext)
        {
            _ticketContext = ticketContext;
        }

        [HttpGet]
        public IActionResult GetAllTickets()
        {
            var tickets = _ticketContext.GetTickets();

            return Ok(_ticketContext.GetTickets());
        }

        [HttpGet]
        [Route("{ticketId}")]
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
        [Route("{ticketId}")]
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

            ticket.SubmitterName = postTicketRequest.SubmitterName;
            ticket.SubjectLine = postTicketRequest.SubjectLine;
            ticket.SubmitterEmail = postTicketRequest.SubmitterEmail;
            ticket.SubmittedTime = System.DateTime.UtcNow;
            ticket.Problem = postTicketRequest.Problem;

            ticket.AssignedTo = "UnAssigned";
            ticket.Priority = 4;
            ticket.Status = "In Progress";
            ticket.Solution = "None";

            var dbTicket = _ticketContext.AddTicket(ticket);
            return Created("I made you", dbTicket);
        }

        [HttpPut]
        [Route("{ticketID}")]
        public IActionResult UpdateTicket([FromBody] PostTicketRequest postTicketRequest, [FromRoute] int ticketID)
        {
            var ticket = new Tickets();
            ticket.SubjectLine = postTicketRequest.SubjectLine;
            ticket.SubmitterName = postTicketRequest.SubmitterName;
            ticket.SubmitterEmail = postTicketRequest.SubmitterEmail;
            ticket.Problem = postTicketRequest.Problem;

            ticket.Solution = postTicketRequest.Solution;
            ticket.AssignedTo = postTicketRequest.AssignedTo;
            ticket.Priority = postTicketRequest.Priority;
            ticket.Status = postTicketRequest.Status;

            var dbTicket = _ticketContext.UpdateTicket(ticket, ticketID);

            if (dbTicket == null)
            {
                return NotFound($"{nameof(ticketID)}: {ticketID} does not exist");
            }

            return Created($"https://localhost:5001/{dbTicket.TicketID}", dbTicket);
        }
    }
}
