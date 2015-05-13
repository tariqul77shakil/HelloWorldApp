using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int age;
            Console.WriteLine("Enter your name.\n\n\n");
            string nameTitle = Console.ReadLine();
            Console.WriteLine("Enter your age.\n\n\n");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n\nYour name is = " + nameTitle);
            Console.WriteLine("Your Age is = " + age);
            Console.ReadKey();
        }
    }
}
