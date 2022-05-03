using BackEndApi.Services.DALModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndApi.Models.Ticket
{
    public class Tickets
    {
        [Key]
        public int TicketID { get; set; }
        public string SubmitterName { get; set; }
        public string SubmitterEmail { get; set; }
        public string SubjectLine { get; set; }
        public string Problem { get; set; }
        public DateTime SubmittedTime { get; set; } = DateTime.UtcNow;

        public string Solution { get; set; }
        public int Priority { get; set; }
        public string AssignedTo { get; set; }
        public string Status { get; set; }
        public DateTime ResolvedTime { get; set; }

        //[ForeignKey("Users")]
        //public int ID { get; set; }
        public IEnumerable<Users> Users { get; set; }

    }
}
