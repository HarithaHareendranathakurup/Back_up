using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity1;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int id = int.Parse(Console.ReadLine());
            string stu = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int cti = int.Parse(Console.ReadLine());
            Student2 s = new Student2();
            {
                s.Id = id;
                s.Student = stu;
                s.Age = a;
                s.ClassTeacherId = cti;
            };

            BL bl = new BL();
            bl.s(s);
        }
    }
}
