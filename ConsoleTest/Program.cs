// See https://aka.ms/new-console-template for more information
using IDalTacheRepository = F23L055_GestToDo.Dal.Repositories.ITacheRepository;
using DalTacheService = F23L055_GestToDo.Dal.Services.TacheService;
using F23L055_GestToDo.Bll.Entities;
using F23L055_GestToDo.Bll.Services;
using System.Data.Common;
using System.Data.SqlClient;
using F23L055_GestToDo.Bll.Repositories;
using DalTache = F23L055_GestToDo.Dal.Entities.Tache;

using (DbConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=F23L055_GestToDo;Integrated Security=True;"))
{
    IDalTacheRepository dalTacheRepository = new DalTacheService(connection);
    ITacheRepository tacheRepository = new TacheService(dalTacheRepository);
    //Tache tache = new Tache("Test Bll");
    //tacheRepository.CreerTache(tache);

    foreach(Tache tache in tacheRepository.Get())
    {
        Console.WriteLine(tache.Titre);
    }
}
