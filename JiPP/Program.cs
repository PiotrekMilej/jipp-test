using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ZAD1");
        int n1 = 20;
        int n2 = 10;

        if (n1 > n2)
        {
            Console.WriteLine($"{n1} jest większe od {n2}\n");
        }
        else if (n1 < n2)
        {
            Console.WriteLine($"{n1} jest mniejsze od {n2}\n");
        }
        else
        {
            Console.WriteLine($"{n1} jest równe {n2}\n");
        }


        Console.WriteLine("ZAD2");
    
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("C#");
        }

        int j = 0;
        while (j < 10)
        {
            Console.WriteLine("C#");
            j++;
        }
        Console.WriteLine("\n");
        Console.WriteLine("ZAD3");
        int n = 10;

        for (int i = 0; i <= n; i++)
            {
              if (i % 2 == 0)
                    Console.WriteLine($"{i} - Parzysta");
              else
                    Console.WriteLine($"{i} - Nieparzysta");
            }
        }
}