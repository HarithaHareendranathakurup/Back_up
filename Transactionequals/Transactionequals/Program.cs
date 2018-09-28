using System;
public class Transaction
{
    private int transid;
    private double transamt;
    private DateTime transdate;
    public Transaction() { }
    public void settransid(int transid)
    {
        this.transid = transid;
    }
    public int gettransid()
    {
        return transid;
    }
    public void settransamt(double transant)
    {
        this.transamt = transamt;
    }
    public double gettransamt()
    {
        return transamt;
    }
    public void settransdate(DateTime transid)
    {
        this.transdate = transdate;
    }
    public DateTime gettransdate()
    {
        return transdate;
    }

}
public class Trans
{
    public static void Main()
    {
        Transaction ob = new Transaction();
        int transid = Convert.ToInt32(Console.ReadLine());
        double transamt = Convert.ToDouble(Console.ReadLine());
        string s = Console.ReadLine();
        DateTime transdate = DateTime.Parse(s);
        ob.settransid(transid);
        ob.settransamt(transamt);
        ob.settransdate(transdate);
        Transaction ob1 = new Transaction();
        Transaction ob2 = ob1;
        if (ob.Equals(ob1))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
        if (ob1.Equals(ob2))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");

    }
}
