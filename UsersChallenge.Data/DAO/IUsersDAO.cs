using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersChallenge.Models;

namespace UsersChallenge.Data.DAO
{
    public interface IUsersDAO
    {
        void Add(User user);
        void Update(User user);
        IList<User> ListAllUsers();
        User GetUserById(int userId);
    }
}
