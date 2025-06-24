using Backend.Controllers;

namespace Backend.Services
{
    public interface IPeopleService
    {

        //Crear la especificación de un método

        //Especificar que existe un método 'Validate' a todas las clases
        //que implemente la interfaz
        bool Validate(People people);
    }
}
