int suma = 0;

while (suma <= 100)
{
    Console.WriteLine("Ingrese un número: ");
    Console.WriteLine();
    int numero= int.Parse(Console.ReadLine());
    Console.WriteLine();
    suma += numero;

}

Console.WriteLine("La suma llegó al limite de ser menor o igual a 100");