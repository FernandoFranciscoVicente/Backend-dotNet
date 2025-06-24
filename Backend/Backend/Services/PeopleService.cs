using Backend.Controllers;

namespace Backend.Services
{
    //Implementamos la interfaz IPeopleService
    public class PeopleService : IPeopleService
    {
        public bool Validate (People people)
        {
            if (string.IsNullOrEmpty(people.Name) ||
                    people.Name.Length > 100 ||
                    people.Name.Length < 3)
            {
                return false; // El nombre es inválido
            }
            return true; // El nombre es válido
        }
    }
}
