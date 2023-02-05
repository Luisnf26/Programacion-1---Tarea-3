using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int max = int.MinValue;
            int maxIndex = 0;

            Console.WriteLine("Ingrese 10 numeros enteros: ");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine("El numero mas grande es: " + max);
            Console.WriteLine("Se encuentra en la posicion: " + (maxIndex + 1));
            Console.ReadLine();
        }
    }
}
