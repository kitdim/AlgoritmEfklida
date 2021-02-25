using System;

namespace AlgoritmEfklida
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hi!\n" +
                              "This is my demo of Euclid's algorithm.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Write numerator: ");     double numerator = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write denumerator: ");   double denumerator = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Your fraction {0}/{1}",numerator,denumerator);
            double a=numerator,b=denumerator;
            for (int i = 0; i < 10000; i++)
            {
                if (a != b)
                {
                    if (a > b)
                        a = a - b;
                    else
                        b = b - a;
                }
            }
            Console.WriteLine("Can be abbreviated by {0}", a);
            Console.WriteLine("Abbreviated fraction {0}/{1}",numerator/a,denumerator/a);
            Console.ReadKey();
        }
    }
}
