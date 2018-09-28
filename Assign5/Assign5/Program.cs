using System;
using System.Collections;

public class Person
{
    public string name;
    public Person() { }

}
public class Test
{
    public static void Main()
    {
        //String nm=Console.ReadLine();
        Person obj1 = new Person();
        obj1.name = "John";

        Person obj2 = new Person();
        obj2.name = "Bill";

        Person obj3 = new Person();
        obj3.name = "Dell";

        Person obj4 = new Person();
        obj4.name = "Misha";
        int c = 0;
        ArrayList list = new ArrayList();
        list.Add(obj1);
        list.Add(obj2);
        list.Add(obj3);
        list.Add(obj4);
        list.Add("123");

        try
        {

            foreach (Person p in list)
            {

                if(p.GetType()==typeof(Person))
                    Console.WriteLine(p.name);
                //else if (p.GetType() == typeof(String)) ;
                   // Console.WriteLine(p);
                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unable to cast object");
        }

        Console.ReadKey();
    }

}

