using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_With_Navneet
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Hello" + " " + name);
            Console.ReadKey();
        }
    }
}
