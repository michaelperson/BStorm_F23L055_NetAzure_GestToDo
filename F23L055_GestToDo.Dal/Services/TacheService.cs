using F23L055_GestToDo.Dal.Entities;
using F23L055_GestToDo.Dal.Mappers;
using F23L055_GestToDo.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Database;

namespace F23L055_GestToDo.Dal.Services
{
    public class TacheService : ITacheRepository
    {
        private readonly DbConnection _connection;

        public TacheService(DbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Tache> Get()
        {
            _connection.Open();
            IEnumerable<Tache> result = _connection.ExecuteReader("CSP_GetTaches", (dr) => dr.ToTache(), true);
            _connection.Close();
            return result;
        }

        public Tache? getById(int id)
        {
            _connection.Open();
            Tache? result = _connection.ExecuteReader(
               "SELECT Id, Titre, Finalise From Tache Where Id= @id",
               (dr) => dr.ToTache(),
               false,
               new { id })
                .SingleOrDefault();
            _connection.Close();
            return result;
        }
          
        public bool CreerTache(Tache tache)
        {
            _connection.Open();
            int rows = _connection.ExecuteNonQuery("CSP_CreerTache", true, new { tache.Titre });
            _connection.Close();
            return rows == 1;
        }

       
    }
}
