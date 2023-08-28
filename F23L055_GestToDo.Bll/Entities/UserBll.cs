using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Bll.Entities
{
    public class UserBll
    {
        public int Id { get; init; }
        public string Email { get; set; }
        public string  MotDePasse { get;set; }
        public string Role { get;set; }
    }
}
