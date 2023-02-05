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
            int count = 0;

            Console.WriteLine("Ingrese 10 numeros enteros: ");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (IsPrime(numbers[i].ToString()[0] - '0'))
                {
                    count++;
                }
            }

            Console.WriteLine("Hay " + count + " numeros que comienzan con un digito primo");
            Console.ReadLine();
        }
    }
}
