using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void Addsub(int a, int b);

namespace Assigndel
{
    class Program
    {
        static void Main(string[] args)
        {
            Addsub a = new Addsub(add);
            Addsub b = new Addsub(sub);
           //a(10, 5);
            //b(10, 5);
            Addsub c = a + b;
            c(50,10);
           // Console.WriteLine(c);
            Console.ReadKey();
        }
        public static void add(int a,int b)
        {
            int z = a + b;
            Console.WriteLine(z);
            //return z;
        }
        public static void sub(int a,int b)
        {
            int y = a - b;
            Console.WriteLine(y);
            //return y;
        }
    }
}
