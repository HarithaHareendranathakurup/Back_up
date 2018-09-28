using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except4
{
    class MyProgram
    {
        public static void Main(string[] args)
        {
            try
            {
                int y = 0;
                int x = 10 / y;
            }
            finally
            {
                Console.WriteLine("Flow reaches Finally");
            }
            Console.ReadKey();
        }
    }

}
