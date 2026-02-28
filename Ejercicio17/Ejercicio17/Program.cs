int numero = 1;
int suma = 0;
Console.WriteLine("Presione 0 para terminar.");
while (numero != 0)
{
    Console.WriteLine();
    Console.WriteLine("Ingrese un número: ");
    numero=int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        suma += 1;
    }
}
Console.WriteLine($"Ha ingresado: {suma} numeros positivos");