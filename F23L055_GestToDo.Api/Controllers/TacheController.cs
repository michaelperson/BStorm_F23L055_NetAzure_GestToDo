using F23L055_GestToDo.Api.Dtos;
using F23L055_GestToDo.Bll.Entities;
using F23L055_GestToDo.Bll.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F23L055_GestToDo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacheController : ControllerBase
    {
        private readonly ITacheRepository _tacheRepository;

        public TacheController(ITacheRepository tacheRepository)
        {
            _tacheRepository = tacheRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tacheRepository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Tache? lapetitetache = _tacheRepository.GetById(id);
            return lapetitetache==null?NotFound(): Ok(lapetitetache);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreeTacheDto dto)
        {
            if(!_tacheRepository.CreerTache(new Tache(dto.Titre)))
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
