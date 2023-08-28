using F23L055_GestToDo.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Dal.Repositories
{
    public interface ITacheRepository
    {
        IEnumerable<Tache> Get();
        Tache? getById(int id);
        bool CreerTache(Tache tache);
    }
}
