int numero = 0;

for (int i=1; i<=4; i++)
{
    for( int j=1; j<=4; j++)
    {
        Console.Write($" {j + numero}");
    }
    Console.WriteLine();
    numero += 1;
}