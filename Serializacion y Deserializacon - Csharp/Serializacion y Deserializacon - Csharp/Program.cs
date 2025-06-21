using System.Text.Json;

//InicializamoS el objeto fernando de la clase People sin usar el constructor
var fernando = new People()
{
    Name = "Fernando",
    Age = 25
};

//Serializamos el objeto a JSON
string json = JsonSerializer.Serialize(fernando);
Console.WriteLine(json);

//Guardar el JSON en un string
string myJson = @"
{
""Name"":""Juan"",
""Age"":29
}";

People juan = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine(juan.Name);
Console.WriteLine(juan.Age);

//Creamos una clase
public  class People
{
    public string Name { get; set; }

    public int Age { get; set; }
}