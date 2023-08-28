using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Dal.Entities
{
    public class UserDal
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string  MotDePasse { get;set; }
        public string Role { get;set; }
    }
}
