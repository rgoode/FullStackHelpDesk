//using BackEndApi.Models.Ticket;
//using BackEndApi.Services.DALModels;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Options;
//using System.Collections.Generic;

//namespace BackEndApi.Services
//{
//    public class UserContext : DbContext, IUserContext
//    {
//        private readonly string _connectionString;

//        public DbSet<Tickets> Tickets { get; set; }
//        public DbSet<Users> Users { get; set; }

//        public Users GetUser(int userId)
//        {
//            var dbUsers = Users.Find(userId);

//            return dbUsers;
//        }

//        public Users DeleteUser(int userId)
//        {
//            var dbUsers = Users.Find(userId);

//            if (dbUsers != null)
//            {
//                var entity = Users.Remove(dbUsers).Entity;
//                SaveChanges();
//                return entity;
//            }
//            return null;
//        }

//        public Users AddUser(Users users)
//        {
//            Users userEntity = Users.Add(users).Entity;
//            SaveChanges();
//            return userEntity;
//        }

//        public Users UpdateUser(Users users, int userID)
//        {
//            var dbUsers = Users.Find(userID);
//            if (dbUsers != null)
//            {
//                //have to still what we are updating here

//                var entityUsers = Users.Update(dbUsers).Entity;
//                SaveChanges();
//                return entityUsers;
//            }
//            return null;
//        }

//        public IEnumerable<Users> GetUsers()
//        {
//            return Users;
//        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(
//             this._connectionString);
//        }
//    }
//}
