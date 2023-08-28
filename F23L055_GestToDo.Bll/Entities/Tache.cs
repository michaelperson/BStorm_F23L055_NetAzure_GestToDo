using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Bll.Entities
{
    public class Tache
    {
        public int Id { get; init; }
        public string Titre { get; set; }
        public bool Finalise { get; set; }

        public Tache(string titre)
        {
            Titre = titre;
        }

        internal Tache(int id, string titre, bool finalise)
        {
            Id = id;
            Titre = titre;
            Finalise = finalise;
        }
    }
}
