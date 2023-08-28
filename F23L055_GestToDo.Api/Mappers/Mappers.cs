using F23L055_GestToDo.Api.Dtos;
using F23L055_GestToDo.Bll.Entities;

namespace F23L055_GestToDo.Api.Mappers
{
    public static class Mappers
    {
        public static UserBll ToBll(this CreateUserDto dto)
        {
            return new UserBll()
            {
                Email = dto.Email,
                MotDePasse = dto.MotDePasse,
                Role = dto.Role.ToString()
            };
        } 

        public static UserBll ToBll(this LoginDto dto)
        {
            return new UserBll()
            {
                Email = dto.Email,
                MotDePasse = dto.Password
            };
        }
    }
}
