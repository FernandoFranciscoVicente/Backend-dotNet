using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeController : ControllerBase
    {

        //Creación de un método síncrono
        [HttpGet("sync")]

        public IActionResult GetSync()
        {
            //Añadimos un cronómetro para medir el tiempo de ejecución
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            // Simulación de una operación que toma tiempo
            Thread.Sleep(2000);
            Console.WriteLine("Operación a BD terminada...");

            Thread.Sleep(2000);
            Console.WriteLine("Envío de mail terminado...");


            Console.WriteLine("Todo ha terminado correctamente");
            // Detenemos el cronómetro
            stopwatch.Stop();
            return Ok(stopwatch.Elapsed);
        }

        [HttpGet("async")]
        //Solo regresará una respuesta HTTP cuando se complete la tarea asíncrona
        public async Task<IActionResult> GetAsync()
        { 
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            var task1 = new Task<int>(() =>
            {
                // Simulación de una operación que toma tiempo
                Thread.Sleep(1000);
                Console.WriteLine("Operación a BD terminada...");
                return 11;
            });

            var task2 = new Task<int>(() =>
            {
                // Simulación de una operación que toma tiempo
                Thread.Sleep(1000);
                Console.WriteLine("Envío de mail terminado...");
                return 12;
            });

            task1.Start();
            task2.Start();

            Console.WriteLine("Aquí se hace otra tarea...");

            //Verificamos si las tareas han terminado para retornarlo
           var result1 = await task1;
           var result2 = await task2;

            Console.WriteLine("Todo ha terminado...");

            stopwatch.Stop();

            return Ok(result1 + " " + result2 + " " + stopwatch.Elapsed);

        }
    }
}
