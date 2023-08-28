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
    public class UserDalService : IUserDalRepository
    {
        private readonly DbConnection _connection;

        public UserDalService(DbConnection connection)
        {
            _connection = connection;
        }
         
        public UserDal Creer(UserDal leUser)
        {
            _connection.Open();
            decimal Id =(decimal) _connection.ExecuteScalar("CSP_CreateUser", true, new 
            {
               Email= leUser.Email,
               MotDePasse = leUser.MotDePasse,
               Role = leUser.Role
            });
             leUser.Id = (int)Id;

            _connection.Close();
            return leUser;          

        }

        public LoginUserDal? Login(UserDal LeUserToConnectUneFois)
        {
            _connection.Open();
            LoginUserDal? ldal = _connection.ExecuteReader("CSP_POURSECONNECTER",
                (ligne) =>ligne.ToLoginUserDal(), true, new { LeUserToConnectUneFois.Email, LeUserToConnectUneFois.MotDePasse } ).SingleOrDefault();
            _connection.Close();
            return ldal;
        }
    }
}
