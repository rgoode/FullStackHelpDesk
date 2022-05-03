using BackEndApi.Models.Ticket;
using BackEndApi.Services.DALModels;
using BackEndApi.Services.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BackEndApi.Services
{
    [ApiController]
    [Route("[controller]")]
    public class MainControllerContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Users> Users { get; set; }

        private readonly IMainControllerContext _mainControllerContext;

        public MainControllerContext(IMainControllerContext mainControllerContext)
        {
            _mainControllerContext = mainControllerContext;
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

        [HttpGet]
        public IActionResult GetAllTickets()
        {
            var students = _mainControllerContext.GetTickets();

            return Ok(_mainControllerContext.GetTickets());
        }

        [HttpGet]
        [Route("{ticketId}")]
        public IActionResult GetTicket([FromRoute] int ticketId)
        {
            var ticket = _mainControllerContext.GetTicket(ticketId);
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
            var ticket = _mainControllerContext.DeleteTicket(ticketId);
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

            ticket.SubjectLine = postTicketRequest.SubjectLine;
            ticket.SubmitterEmail = postTicketRequest.SubmitterEmail;
            ticket.SubmittedTime = System.DateTime.UtcNow;
            ticket.Problem = postTicketRequest.Problem;

            ticket.AssignedTo = "UnAssigned";
            ticket.Priority = 4;
            ticket.Status = "In Progress";
            ticket.Solution = "None";

            var dbTicket = _mainControllerContext.AddTicket(ticket);
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

            var dbTicket = _mainControllerContext.UpdateTicket(ticket, ticketID);

            if (dbTicket == null)
            {
                return NotFound($"{nameof(ticketID)}: {ticketID} does not exist");
            }

            return Created($"https://localhost:5001/{dbTicket.TicketID}", dbTicket);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
             this._connectionString);
        }
    }
}
