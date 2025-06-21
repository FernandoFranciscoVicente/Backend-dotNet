//--Crear clases y objetos

//Creamos un objeto de la clase Sale
Sale sale = new SaleWithTax(12, 1.16m);
//Llamamos al método GetInfo del objeto sale
var message = sale.GetInfo();



// Imprimimos el mensaje en la consola
Console.WriteLine(message);


//Definimos la clase que hereda de Sale
class SaleWithTax : Sale
{
    public decimal Tax { get; set; }
    public SaleWithTax(decimal total, decimal  tax ) : base(total)
    {
        Tax = tax;
    }
    public override string GetInfo()
    {
        return "El total es: " + Total + " y el impuesto es: " + Tax;

    }
}


//1. Definimos una clase llamada Sale
class Sale
{
    //Encapsulamos el comportamiento
    //La clase es pública para poder acceder a ella desde otros archivos
    //El tipo decimal es adecuado para representar cantidades monetarias
    //El set y get permiten acceder a las propiedades de la clase
    public decimal Total { get; set; }

    //Definimos un constructor
    public Sale(decimal total)
    {
        //El this hace referencia a los elementos de la clase
        this.Total = total;
    }

    //Definimos un método para obtener información de la venta
    public virtual string GetInfo()
    {
        return "El total es: " + Total;
    }
}





//--Herencia de clases

//Definimos la clase padre 'Animal'
class Animal
{
    public string Nombre;

    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }
}

//Herencia de la clase Animal
class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} está ladrando.");
    }
}