using System;
using System.Collections;
public class Program
{
    public static void Main()
    {
        ArrayList al = new ArrayList();
        int mid, avg, sum = 0, c;
        bool acceptFlag = false;
        while (!acceptFlag)
        {
            Console.WriteLine("Enter some integer");
            int i = int.Parse(Console.ReadLine());
            al.Add(i);
            Console.WriteLine("Do you want to continue? Y/N");
            char accept = char.Parse(Console.ReadLine().ToString().ToUpper());
            if (accept == 'Y')
            {
                acceptFlag = true;
            }
            else
            {
                acceptFlag = false;
            }
        }
        Console.WriteLine(al.Count);
        c = al.Count;
        if (c % 2 == 0)
            mid = (c / 2) + 1;
        else
            mid = c / 2;
        foreach (int i in al)
        {
            sum = sum + i;
        }
        avg = sum / c;
        al.Insert(mid, avg);
        al.Remove(5);//REMOVES THE ELEMENT 5 FROM THE LIST
        al.RemoveAt(mid);
        foreach (int i in al)
        {
            Console.WriteLine(i);
        }
    }
}
