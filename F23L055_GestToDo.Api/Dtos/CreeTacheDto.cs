using System.ComponentModel.DataAnnotations;

namespace F23L055_GestToDo.Api.Dtos
{
#nullable disable
    public class CreeTacheDto
    {
        [Required]
        public string Titre { get; set; }
    }
}
