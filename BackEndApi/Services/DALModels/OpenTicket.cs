using System;

namespace BackEndApi.Models.Ticket
{
    public class OpenTicket
    {
        public int Id { get; set; }
        public string RequestTitle { get; set; }
        public string Name { get; set; }
        public string Problem { get; set; }
        public string Solution { get; set; }
        public int Priority { get; set; }
        public DateTime SubmittedTime { get; set; }
        public string AssignedTo { get; set; }
        public bool Favorited { get; set; }
        public DateTime ResolvedTime { get; set; }
    }
}
