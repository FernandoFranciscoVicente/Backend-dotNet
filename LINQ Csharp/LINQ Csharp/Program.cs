//LINQ en C#
//Origen de los datos
var names = new List <string>() 
{
    "Alice","Bob","Charlie","David","Evee"
};

//Consulta LINQ
var namesResult = from n in names
                  where n.Length > 3 && n.Length < 5
                  orderby n descending
                  select n;

//Función anónima
var namesResult2 = names.Where (n => n.Length > 3 && n.Length < 5)
                        .OrderByDescending(n => n)
                        .Select(d => d);


// Ejecución de la consulta
foreach (var name in namesResult)
{
    Console.WriteLine(name);
}