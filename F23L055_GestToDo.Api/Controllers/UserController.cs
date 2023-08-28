using F23L055_GestToDo.Api.Dtos;
using F23L055_GestToDo.Api.Mappers;
using F23L055_GestToDo.Bll.Entities;
using F23L055_GestToDo.Bll.Repositories; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F23L055_GestToDo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBllRepository _userBllRepository;

        public UserController(IUserBllRepository userBllRepository)
        {
            this._userBllRepository= userBllRepository;
        }

        [HttpPost]
        public IActionResult create(CreateUserDto toCreate)
        {
            if(toCreate == null) { return NotFound(); }

            if (toCreate.MotDePasse != toCreate.ConfirmMotDePasse) { return NotFound(); }



            var reponse = _userBllRepository.CreateUser(toCreate.ToBll());

            // return NoContent ();
            return new CreatedAtActionResult(nameof(create),
                                 "User",
                                 new { id = reponse.Id },
                                 reponse);
        }

        [HttpPost("Login")]
        public IActionResult login(LoginDto tologin)
        {
            if (tologin == null) return NotFound(login);
            string? reponse = _userBllRepository.Login(tologin.ToBll());
            if(reponse == null) return NotFound();
            return Ok(reponse);
        }
    }
}
