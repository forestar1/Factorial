using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a, b;
            //Console.WriteLine("Введіть а:");
            //double.TryParse(Console.ReadLine(), out a);
            //Console.WriteLine("Введіть b:");
            //double.TryParse(Console.ReadLine(), out b);
            //if (b != 0)
            //{
            //    Console.WriteLine(a / b);
            //}
            int c,i,fact=1;
            Console.WriteLine("Введіть c:");
            int.TryParse(Console.ReadLine(), out c);
            for (i = 1; i <= c; i++)
            {
               fact *= i;
            }
            Console.WriteLine("{0}!={1}", c, fact);
              }
    }
}
