using F23L055_GestToDo.Bll.Entities;
using F23L055_GestToDo.Bll.Mappers;
using F23L055_GestToDo.Bll.Repositories;
using F23L055_GestToDo.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Bll.Services
{
    public class UserBllService : IUserBllRepository
    {
        private readonly IUserDalRepository _dalRepository;
        public UserBllService(IUserDalRepository dalRepository)
        {
            this._dalRepository = dalRepository;
        }
        public UserBll CreateUser(UserBll zeUser )
        {
            return _dalRepository.Creer(zeUser.ToDal()).ToBll();
        }

        public string? Login(UserBll UserToLog)
        {// insertion
           var log=   _dalRepository.Login(UserToLog.ToDal());
            if(log!=null)
            {
                return "token";
            }
            else
            {
                return null;
            }
        }
    }
}
