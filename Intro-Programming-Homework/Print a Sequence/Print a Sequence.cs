using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_a_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2, count=0; count < 10; count++)
            {
                Console.WriteLine(i);
                if (i>0)
                {
                    i= (i + 1) * -1;
                }
                else
                {
                    i = (i - 1) * -1;
                }
            }
            
        }
    }
}
