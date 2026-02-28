int restar = 1;
int contador = 0;

Console.WriteLine("Ingrese un número: ");
Console.WriteLine();
int numero = int.Parse(Console.ReadLine());
int numeroOriginal = numero;
Console.WriteLine();

while (numero >= 0)
{
    numero = numeroOriginal - restar;
    restar = restar * 10;

    if (numero >= 0 || numero==-1)
    {
        contador = contador + 1;
    }
}
Console.WriteLine($"El la cantidad de dígitos que tiene el número es: {contador}");