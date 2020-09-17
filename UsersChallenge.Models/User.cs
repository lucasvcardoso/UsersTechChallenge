using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersChallenge.Models
{
    public class User
    {
        public int? UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
    }
}
