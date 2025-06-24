namespace Backend.Services
{
    //Implementación de la interfaz IRandomService
    public class RandomService : IRandomService
    {
        private readonly int _value;

        public int Value
        {
            get => _value;
        }

        //Constructor que genere un número aleatorio
        public RandomService()
        {
            // Inicializamos el valor con un número aleatorio entre 0 y 999
            _value = new Random().Next(1000);
        }
    }
}
