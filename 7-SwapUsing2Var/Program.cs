using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;

            Console.Write("Enter 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("1st number is: " + a);
            Console.WriteLine("2nd number is: " + b);

            Console.ReadLine();

        }
    }
}
