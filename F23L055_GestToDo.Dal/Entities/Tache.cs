using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Dal.Entities
{
#nullable disable
    public class Tache
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public bool Finalise { get; set; }
    }
}
