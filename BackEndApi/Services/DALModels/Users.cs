using BackEndApi.Models.Ticket;
using System.Collections.Generic;

namespace BackEndApi.Services.DALModels
{
    public class Users
    {
        [key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public bool IsFavorite { get; set; }

        public int TicketID { get; set; }
    }
}
