using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except5
{
    public class A

    {
        public void methodA()
        {
            try
            {
                B test = new B();
                test.methodB();
            }
            catch (Exception e)
            {
                throw e;
                Console.WriteLine("Exception from Class A");
            }
            finally
            {
                Console.WriteLine("Inside Class A Finally");
            }
            Console.ReadKey();
        }
    }

    public class B
    {
        public void methodB()
        {
            try
            {
                throw new Exception("Exception from Class B");
            }
            catch (Exception e)
            {
                throw;
                Console.WriteLine("Exception from Class A");
            }
            finally
            {
                Console.WriteLine("Inside Class B Finally");
            }
        }
    }

}
