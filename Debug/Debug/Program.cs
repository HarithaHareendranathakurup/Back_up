using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace Generics
    {
        class A
        {
            public virtual void show()
            {
                Console.WriteLine("Hello: Base Class!");
                Console.ReadLine();
            }
        }

        class B : A
        {
            public override void show()
            {
                Console.WriteLine("Hello: Derived Class!");
                Console.ReadLine();
            }
        }

        class C : B
        {
            public new void show()
            {
                Console.WriteLine("Am Here!");
                Console.ReadLine();
            }
        }

        class Polymorphism
        {
            public static void Main()
            {
                C c1 = new C();
                c1.show();
                A a2 = new B();
                a2.show();
                A a3 = new C();
                a3.show();
                B b3 = new C();
                b3.show();
                Console.ReadKey();
            }
        }
    }

}
