using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
s
namespace Age_after_10_Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleasy write your age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Your age after ten years will be " + (age + 10) + ".");
        }
    }
}
