using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using UsersChallenge.Data.DAO;
using UsersChallenge.Models;

namespace UsersChallengeAPI.Services
{
    public class UsersService
    {
        private readonly string _connectionString;

        public UsersService()
        {
            //In a production environment this instantiation would 
            //instead be an object injected by a dependency injection framework
            _connectionString = "UsersChallengeDatabase";
        }

        public void CreateUser(User user)
        {
            using (UsersDAO dao = new UsersDAO(_connectionString))
            {
                dao.Add(user);
            }
        }

        public void UpdateUser(User user)
        {
            using (UsersDAO dao = new UsersDAO(_connectionString))
            {
                dao.Update(user);
            }
        }

        public IList<User> GetAllUsers()
        {
            using (UsersDAO dao = new UsersDAO(_connectionString))
            {
                return dao.ListAllUsers();
            }
        }

        public User GetUser(int id)
        {
            using (UsersDAO dao = new UsersDAO(_connectionString)) 
            {
                return dao.GetUserById(id);
            }
        }
    }
}