// Función pura

//Ejecutamos la función Sub
Console.WriteLine(Sub(102, 5));
int Sub(int a, int b)
{
    return a - b;
}

//Función no pura

Punto p1 = new Punto(10, 20);
p1.Mostrar();
public struct Punto
{
    public int X;
    public int Y;

    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Mostrar()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}

