using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace StudentEntity
{
    class Student1
    {
        public int Id;
        public string Student;
        public int Age;
        public int ClassTeacherId;
        static void Main(string[] args)
        {
            int id = int.Parse(Console.ReadLine());
            string stu = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int cti = int.Parse(Console.ReadLine());
            Student1 s = new Student1();
            {
                s.Id = id;
                s.Student = stu;
                s.Age = a;
                s.ClassTeacherId = cti;
            };
            BL bl = new BL();
            bl.saveDetails();
        }
    }
}
