using F23L055_GestToDo.Bll.Entities;

namespace F23L055_GestToDo.Bll.Repositories
{
    public interface ITacheRepository
    {
        IEnumerable<Tache> Get();
         Tache? GetById(int id);
        bool CreerTache(Tache tache);
    }
}
