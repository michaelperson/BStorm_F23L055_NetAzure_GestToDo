using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Bll.Entities
{
    internal class LoginUserBll
    {
        public int Id { get; init; }
        public string Email { get; set; } 
        public string Role { get; set; }

        public LoginUserBll(string email, string role) 
        {
            Email = email;
            Role = role;
        }

        internal LoginUserBll(int id )
        {
            Id = id; 
        }

        public LoginUserBll(int id, string email, string role) : this(id)
        {
            Email = email;
            Role = role;
        }
    }
}
