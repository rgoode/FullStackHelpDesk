using BackEndApi.Models.Ticket;
using System.Collections.Generic;

namespace BackEndApi.Services.DALModels
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsFavorite { get; set; }

        public int ID { get; set; }
    }
}
