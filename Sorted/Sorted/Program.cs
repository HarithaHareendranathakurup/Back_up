using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted
{
    class Person
    {
        public string name;
        public int age;
        public string place;
        public Person() { }
        public Person(string nm,int n,string pl)
        {
            name = nm;
            age = n;
            place = pl;
        }
        public bool Canvote(Person ob)
        {
            if (ob.age > 18)
                return true;
            else
                return false;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ram", 25, "chennai");
            Person p1= new Person("Raj", 20, "mumbai");
            Person p2= new Person("Bob", 24, "hyderabad");
            Person p3= new Person("Eva", 26, "pune");
            Person p4 = new Person();
            Console.WriteLine(p4.Canvote(p));
            Console.WriteLine(p4.Canvote(p1));
            Console.WriteLine(p4.Canvote(p2));
            Console.WriteLine(p4.Canvote(p3));

            Hashtable<Person> ht = new Hashtable<Person>();
            ht.Add(p.name,p.age,p.place); ;
            ht.Add(p1.name,p1.age,p1.place);
            ht.Add(p2.name,p2.age,p2.place);
            ht.Add(p3.name,p3.age,p3.place);
            foreach(Person p in ht)
            {
                Console.WriteLine(p.name);
            }
            Console.ReadKey();

        }
    }
}
