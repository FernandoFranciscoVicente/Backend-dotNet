using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        //Creamos un método para la clase
        //Regresamos una lista de objetos (People)
        [HttpGet("all")]
        //Regreamos una lista de objetos People con una función lambda
        public List<People> GetPeople() => Repository.People;

        //Método para filtrar información para respuesta
 //       [HttpGet("{id}")]
        //Creamos una función anónima que recorra toda la lista y compare el id con el pedido
        //en la url de la peticion get 
 //       public People Get(int id) => 
 //           Repository.People.First(funcionAnonima => funcionAnonima.Id == id);

        [HttpGet("{id}")]
        public ActionResult<People> Get(int id)
        {
            var people = Repository.People.FirstOrDefault(p => p.Id == id);

            if(people == null)
            {
                return NotFound();
            }
            return Ok(people);
        }


        //Método para implementar una búsqueda por criterio
        [HttpGet("search/{search}")]
        public List<People> Get(string search) =>
            Repository.People.Where(funcionAnonima =>
            funcionAnonima.Name.ToUpper().Contains(search.ToUpper())).ToList();
    }


    //Simularemos una base de datos en memoria
    public class Repository
    {
        public static List<People> People = new List<People>
        {   //Creamos un objeto de tipo People
            new People { Id = 1, Name = "John Doe", Birhdate = new DateTime(1990, 12, 1) },
            new People { Id = 2, Name = "Jane Smith", Birhdate = new DateTime(1985, 5, 15) },
            new People { Id = 3, Name = "Alice Johnson", Birhdate = new DateTime(2000, 10, 20) },
            new People { Id = 4, Name = "Bob Brown", Birhdate = new DateTime(1995, 3, 30) }
        };
    }

    //Creamos la clase people
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime Birhdate { get; set; }
    }
}
