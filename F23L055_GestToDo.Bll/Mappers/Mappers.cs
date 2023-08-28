using  F23L055_GestToDo.Bll.Entities;
using Dal= F23L055_GestToDo.Dal.Entities;
using DalTache = F23L055_GestToDo.Dal.Entities.Tache;

namespace F23L055_GestToDo.Bll.Mappers
{
    internal static class Mappers
    {
        internal static DalTache ToDal(this Tache entity)
        {
            return new DalTache() { Id = entity.Id, Titre = entity.Titre, Finalise = entity.Finalise };
        }

        internal static Tache ToBll(this DalTache entity)
        {
            return new Tache(entity.Id, entity.Titre, entity.Finalise);
        }

        internal static Dal.Entities.UserDal ToDal(this UserBll entity)
        {
            return new Dal.Entities.UserDal()
            {
                Id = entity.Id,
                Email = entity.Email,
                MotDePasse = entity.MotDePasse,
                Role = entity.Role,
            };
        }

        internal static UserBll ToBll(this Dal.Entities.UserDal entity)
        {
            return new UserBll()
            {
                Id = entity.Id,
                Email = entity.Email,
                Role = entity.Role
            };
        }
    }
}
