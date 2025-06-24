using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {

        //Creamos 6 objetos privados para evaluarlos
        private IRandomService _randomServiceSingleton;
        private IRandomService _randomServiceScoped;
        private IRandomService _randomServiceTransient;

        private IRandomService _randomService2Singleton;
        private IRandomService _randomService2Scoped;
        private IRandomService _randomService2Transient;

        //Acceder a esos objetos por el constructor

        public RandomController(
            [FromKeyedServices("randomSingleton")] IRandomService randomServiceSingleton,
            [FromKeyedServices("randomScoped")] IRandomService randomServiceScoped,
            [FromKeyedServices("randomTransient")] IRandomService randomServiceTransient,
            [FromKeyedServices("randomSingleton")] IRandomService randomService2Singleton,
            [FromKeyedServices("randomScoped")] IRandomService randomService2Scoped,
            [FromKeyedServices("randomTransient")] IRandomService randomService2Transient)
        {
            //Asignamiento de los objetos a las variables privadas
            _randomServiceSingleton = randomServiceSingleton;
            _randomServiceScoped = randomServiceScoped;
            _randomServiceTransient = randomServiceTransient;
            _randomService2Singleton = randomService2Singleton;
            _randomService2Scoped  = randomService2Scoped;
            _randomService2Transient = randomService2Transient;
        }

        //Creamos un método para retornar los valores de los objetos (diccionario)
        [HttpGet]
        public ActionResult<Dictionary<string, int>> Get()
        {
            //Creamos un diccionario de tipo string e int
            var result = new Dictionary<string, int>();
            
                result.Add("Singleton 1", _randomServiceSingleton.Value);
                result.Add("Scoped 1", _randomServiceScoped.Value);
                result.Add("Transient 1", _randomServiceTransient.Value);

                result.Add("Singleton 2", _randomService2Singleton.Value);
                result.Add("Scoped 2", _randomService2Scoped.Value);
                result.Add("Transient 2", _randomService2Transient.Value);


            //Retornamos el resultado
            return Ok(result);
        }
    }
}
