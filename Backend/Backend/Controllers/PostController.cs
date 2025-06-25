using Backend.Services;
using Backend.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        //Crear un campo privado de tipo IPostService
        IPostService _titleService;
        
        //Obtenemos el constructor de manera inyectada

        public PostController(IPostService titleService)
        {
            //Asignamos el campo privado con el valor del parámetro
            _titleService = titleService;
        }

        //Creamos un método tipo GET
        [HttpGet]
        //Objeto que estrá transifieriendose entre capas
        public async Task<IEnumerable<PostDto>>Get() =>
            await _titleService.Get();


    }
}
