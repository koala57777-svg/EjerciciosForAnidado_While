int opcion = 0;

while (opcion != 3)
{
    Console.WriteLine("Elija una opción: ");
    Console.WriteLine();
    Console.WriteLine("1. Mostrar un saludo");
    Console.WriteLine("2. Mostrar los números del 1 al 10");
    Console.WriteLine("3. Salir");
    Console.WriteLine();
    opcion=int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola, espero estes muy bien.");
            break;
        case 2:
            for (int i=1; i<=10; i++)
            {
                Console.Write($"{i} ");
            }
            break;
        case 3:
            Console.WriteLine("Salir del programa");
            break;
        default:
            break;
    }
    Console.WriteLine();
    Console.ReadLine();
    Console.Clear();
}
Console.WriteLine("Saliendo del programa");