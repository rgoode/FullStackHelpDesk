using BackEndApi.Models.Ticket;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndApi.Services.DALModels
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public bool IsFavorite { get; set; }
       
        [ForeignKey("Tickets")]
        public int TicketID { get; set; }
        public IEnumerable<Tickets> Tickets { get; set; }
    }
}
