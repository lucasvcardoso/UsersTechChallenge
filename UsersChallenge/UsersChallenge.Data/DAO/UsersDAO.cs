using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersChallenge.Models;

namespace UsersChallenge.Data.DAO
{
    public class UsersDAO : IUsersDAO, IDisposable
    {
        private UsersContext context;

        public UsersDAO(string connectionString)
        {
            //In a production environment this instantiation
            //would instead be an object injected by the dependency injection framework
            context = new UsersContext(connectionString);           
        }
        public void Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public User GetUserById(int userId)
        {
            var userList = context.Users.Where(u => u.UserId == userId).ToList();
            if (userList.Count > 0)
            {
                return userList.First();
            }
            return null;
        }

        public IList<User> ListAllUsers()
        {
            return context.Users.ToList();
        }

        public void Update(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
