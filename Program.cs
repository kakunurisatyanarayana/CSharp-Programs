using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Boolean isPrime=true;
    public static Boolean prime(int n)
    {

        int i, j;
        int count = 0;
        for (i = 1; i <= n; i++)
        {
            if (n % i == 0)
                count++;
        }
        if (count == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        int j;
        int sum = 0;
        Console.WriteLine("Enter n");
        int n = int.Parse(Console.ReadLine());
        for ( j = 1; j <= n; j++)
        {
            isPrime = prime(j);
            if (isPrime)
            {
                sum = sum + j;
                Console.Write(" "+j);
            }

        }
        Console.WriteLine("\n");
        Console.WriteLine("Sum={0}",sum);

        Console.ReadKey();
    }
}

