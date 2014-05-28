using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Long_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 1002;
            for (int i=2, count = 2; count < 1002; count++)
            {
                Console.WriteLine(i);
                if (i>0)
                {
                    i = (i + 1) * -1;
                }
                else
                {
                    i = (i - 1) * -1;
                }
                                  
            }
        }
    }
}
