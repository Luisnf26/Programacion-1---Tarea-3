using System;

namespace ConsoleApp
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int max = int.MinValue;
            int maxIndex = -1;

            Console.WriteLine("Ingrese 10 numeros enteros: ");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (IsPrime(numbers[i]) && numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }
            }

            if (maxIndex == -1)
            {
                Console.WriteLine("No se leyo ningun numero primo");
            }
            else
            {
                Console.WriteLine("El numero primo mas grande es: " + max);
                Console.WriteLine("Se encuentra en la posicion: " + (maxIndex + 1));
            }

            Console.ReadLine();
        }
    }
}
