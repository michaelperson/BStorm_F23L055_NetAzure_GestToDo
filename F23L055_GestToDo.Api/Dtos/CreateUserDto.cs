using F23L055_GestToDo.Api.Enumeration;

namespace F23L055_GestToDo.Api.Dtos
{
    public class CreateUserDto
    {
         
        public string Email { get; set; }
        public string MotDePasse { get; set; }

        public string ConfirmMotDePasse { get; set; }

        public ERole Role { get; set; }
    }
}
