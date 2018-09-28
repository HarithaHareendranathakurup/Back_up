using System;
public class Current
{
    string companyName;
    string typeofbusiness;
    string website;
    string contactName;
    Current(string cn, string tob, string web, string conm)
    {
        companyName = cn;
        typeofbusiness = tob;
        website = web;
        contactName = conm;
    }
    public void meth(Current c1, Current c2, Current c3)
    {
        if (c1.Equals(c2))
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
        if (c2.Equals(c3))
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
    public static void Main()
    {
        string cn = Console.ReadLine();
        string tob = Console.ReadLine();
        string web = Console.ReadLine();
        string conm = Console.ReadLine();
        Current c1 = new Current(cn, tob, web, conm);
        Current c2 = new Current(cn, tob, web, conm);
        Current c3 = c2;
        Current c4 = new Current(cn, tob, web, conm);
        c4.meth(c1, c2, c3);

    }
}
