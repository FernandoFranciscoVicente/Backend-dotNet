
var numbers = new MyList<int>(5);
var names = new MyList<string>(5);
var beers = new MyList<Beer>(3);  

numbers.Add(1);
numbers.Add(2); 
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6); // Esto lanzará una excepción porque el límite es 5 

names.Add("Alice");
names.Add("Bob");
names.Add("Charlie");
names.Add("David");
names.Add("Eve");
names.Add("Frank"); // Esto lanzará una excepción porque el límite es 5



beers.Add(new Beer()
{
    Name = "IPA",
    Price = 5.27m
});

beers.Add(new Beer()
{
    Name = "Erdinger",
    Price = 5.27m
});

beers.Add(new Beer()
{
    Name = "XX",
    Price = 5.27m
});

beers.Add(new Beer()
{
    Name = "Paulaner",
    Price = 5.27m
});

beers.Add(new Beer()
{
    Name = "Modelo",
    Price = 5.27m
});

Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(beers.GetContent());  

//Implementando Genericsem C#
public class MyList<T>
{   //Creamos una lista generica
    //Los elementos son privados, por ello agregamos (_)
    private List<T> _list;
    private int _limit;

    //Agregamos un constructor para inicializar la lista y el limite
    public MyList(int limit)
    {
        _limit = limit;
        //Inicializamos el objeto lista
        _list = new List<T>();
    }

    public void Add(T element)
    {
        //Validamos que no se supere el limite
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    // Método para obtener el contenido de la lista
    public string GetContent()
    {
        string content = "";
        foreach (var element in _list)
        {
            content += element + ", ";
        }
        return content;
    }
}

//Creamos una clase llamada Beer
public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Nombre: " + Name + ", Precio: " + Price;
    }
}