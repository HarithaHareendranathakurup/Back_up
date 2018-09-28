using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except3
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            int index;
            int value = 100;
            int[] arr = new int[10];
            try
            {
                Console.Write("Enter a number: ");
                index = Convert.ToInt32(Console.ReadLine());
                arr[index] = value;
            }
            catch (FormatException e)
            {
                Console.Write("Bad Format ");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("Index out of bounds ");
            }
            Console.Write("Remaining program ");
            Console.ReadKey();
        }
    }

}
