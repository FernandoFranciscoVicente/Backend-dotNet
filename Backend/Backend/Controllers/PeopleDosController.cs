using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleDosController : ControllerBase
    {

        //Nuevo método que contiene interfaz de retorno
        [HttpPost]
        //IActionResult no recibe un tipo, pues no retorna nada
        public IActionResult Add(People people)
        {   //Validar que el nombre de la persona exista
            if (string.IsNullOrEmpty(people.Name))
            {
                return BadRequest();
            }
            //Se guarda en la memoria RAM
            Repository.People.Add(people);
            return NoContent();
        }
    }

}
