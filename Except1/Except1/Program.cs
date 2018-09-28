using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentException();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Caught");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hai");
            }
            
            Console.ReadKey();

        }
    }
}
