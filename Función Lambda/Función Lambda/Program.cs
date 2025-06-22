//Función lambda en C#
//Funciones que no tienen nombres pero si tienen definido lo que hacen

//Expresión lambda
Func<int, int, int> sub = (a, b) => a - b;

//Es lo mismo que la función normal
int sub2(int a, int b)
{
    return a - b;
}

Func<int, int> some = (a) =>  a * 2;


Func<int, int> some2 = a =>
{
    a = a + 1;
    return a * 5;
};

//Se ejecuta la función
sub(5, 3);