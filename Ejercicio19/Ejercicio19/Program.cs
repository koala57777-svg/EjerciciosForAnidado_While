int multiplo = 1;

Console.WriteLine("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Tabla del {numero}");
Console.WriteLine();

while (multiplo <= 10)
{
    
    Console.WriteLine($"{numero} x {multiplo} = {numero*multiplo}");
    multiplo++;

}