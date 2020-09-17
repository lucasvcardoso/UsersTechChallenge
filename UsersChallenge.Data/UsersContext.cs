using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersChallenge.Models;

namespace UsersChallenge.Data
{
    public class UsersContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<User> Users { get; set; }


        public UsersContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase(_connectionString);
            }
        }

    }
}
