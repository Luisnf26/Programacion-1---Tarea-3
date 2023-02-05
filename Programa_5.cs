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

        static int CountEvenDigits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if ((n % 10) % 2 == 0)
                {
                    count++;
                }
                n /= 10;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int maxEvenDigits = 0;
            int maxIndex = -1;

            Console.WriteLine("Ingrese 10 numeros enteros: ");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (IsPrime(numbers[i]))
                {
                    int evenDigits = CountEvenDigits(numbers[i]);
                    if (evenDigits > maxEvenDigits)
                    {
                        maxEvenDigits = evenDigits;
                        maxIndex = i;
                    }
                }
            }

            if (maxIndex >= 0)
            {
                Console.WriteLine("El número primo con mayor cantidad de digitos pares está en la posicion " + (maxIndex + 1));
            }
            else
            {
                Console.WriteLine("No se encontro ningun numero primo");
            }
            Console.ReadLine();
        }
    }
}
