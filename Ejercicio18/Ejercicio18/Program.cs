using static System.Runtime.InteropServices.JavaScript.JSType;
int restar = 1;
Console.WriteLine();
Console.WriteLine("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());
int numeroinicial = numero;

while(numero>=0 && (numeroinicial-restar)>=1)
{
    
    numero=numero*(numeroinicial-restar);
    restar++;

}
Console.WriteLine();
Console.WriteLine($"El factorial del numero ingresado es: {numero}");