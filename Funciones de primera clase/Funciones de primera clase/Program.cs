//Funciones de primera clase
var show = Show;

Some(show, "Hola, aquí se está haciendo algo también");

void Show(string message)
{
    Console.WriteLine(message);
}

//Función que recibe elementos pero no devuelve nada
void Some(Action<string> fn, string message)
{
    Console.WriteLine("Hace algo aquí");
    fn(message);
    Console.WriteLine("Hace algo al final");
}