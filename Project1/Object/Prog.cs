using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BusinessObj;

namespace Object
{
    class Prog
    {
        
        static void Main(string[] args)
        {
            int id = int.Parse(Console.ReadLine());
            string stu = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int cti = int.Parse(Console.ReadLine());
            Enty e=new Enty();
            {
                e.Id = id;
                e.Student = stu;
                e.Age = a;
                e.ClassTeacherId = cti;
            };
            Buss ob = new Buss();
            ob.save(e);

        }
    }
}
