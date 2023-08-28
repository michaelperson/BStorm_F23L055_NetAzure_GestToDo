using F23L055_GestToDo.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace F23L055_GestToDo.Dal.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static Tache ToTache(this IDataRecord record)
        {
            return new Tache()
            {
                Id = (int)record["Id"],
                Titre = (string)record["Titre"],
                Finalise = (bool)record["Finalise"]
            };
        }

        internal static LoginUserDal ToLoginUserDal(this IDataRecord ligne)
        {
            return new LoginUserDal()
            {
                Email = ligne["Email"].ToString(),
                Id = (int)ligne["Id"],
                Role = ligne["Role"].ToString()
            };
        }
    }
}
