int numero = 0;

for (int i=1; i<=3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.Write($" {j + numero}");
       
    }
    Console.WriteLine();
    numero=numero+3;
}