// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enteros, positivos, negativos, par, impar");

Console.WriteLine();

{

    Console.WriteLine("Ingrese la cantidad de números a evaluar:");
    int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

    int positivos = 0;
    int negativos = 0;
    int pares = 0;
    int impares = 0;

    for (int i = 0; i < cantidadNumeros; i++)
    {
        Console.WriteLine("Ingrese el número " + (i + 1) + ":");
        int numero = Convert.ToInt32(Console.ReadLine());

       
        if (numero > 0)
        {
            positivos++;
        }
        else if (numero < 0)
        {
            negativos++;
        }

       
        if (numero % 2 == 0)
        {
            pares++;
        }
        else
        {
            impares++;
        }
    }

    Console.WriteLine("Cantidad de números positivos: " + positivos);
    Console.WriteLine("Cantidad de números negativos: " + negativos);
    Console.WriteLine("Cantidad de números pares: " + pares);
    Console.WriteLine("Cantidad de números impares: " + impares);
}
