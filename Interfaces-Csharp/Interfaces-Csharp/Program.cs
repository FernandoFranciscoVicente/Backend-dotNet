var sale = new Sale();
var beer = new Beer();

//Invocamos la función con el objeto de tipo Sale  y beer
Some(sale); 
Some(beer);

//Creamos una función
void Some(ISave save)
{
    save.Save();
}


//Creación de una iterfaz

interface ISale
{
    decimal Total { get; }
}

interface ISave
{
    //El método void no retorna nada
    public void Save();
}

// Implementación de la interfaz
public class Sale : ISale, ISave
{
    public decimal Total { get; set; }


    public void Save()
    {
        Console.WriteLine("Guardando venta en BD...");    
    }
}

public class Beer: ISave
{
    public void Save()
    {
        Console.WriteLine("Guardando venta en Servicio...");
    }
}

//La interfaz, a diferencia de la herencia si puede hacerse múltiple
