using System;

namespace BackEndApi.Services.Models
{
    public class PostTicketRequest
    {
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
    }
}
