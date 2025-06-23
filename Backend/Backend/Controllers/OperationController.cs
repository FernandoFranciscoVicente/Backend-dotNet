using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    //HELPER: Especifica que se utiliza el controlador API
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        //HELPER: Especifica que se utiliza el método HTTP GET
        [HttpGet]
        //Especificar un método
        public decimal Get(decimal a, decimal b)
        {
            //Realizar la operación
            return a + b;
        }

        [HttpPost]
        //Especificar un método
        public decimal Add(Numbers numbers, [FromHeader] string Host,
            //Obtener la longitud de la solicitud enviada por el cliente
            [FromHeader(Name = "Content-Length")] string ContentLength)
        {
            //Obtener  el host del servidor
            Console.WriteLine(Host);
            Console.WriteLine(ContentLength);
            //Realizar la operación
            return numbers.A - numbers.B;

        }

        [HttpPut]
        //Especificar un método
        public decimal Edit(decimal a, decimal b)
        {
            //Realizar la operación
            return a * b;
        }

        [HttpDelete]
        //Especificar un método
        public decimal Delete(decimal a, decimal b)
        {
            //Realizar la operación
            return a / b;
        }
    }

    public class Numbers
    {
        public decimal A { get; set; }
        public decimal B{ get; set; }
    }
}
