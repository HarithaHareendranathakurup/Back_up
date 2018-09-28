using System;

public class Transaction
{
    public int transid;
    public double transamt;
    public DateTime transdate;
    public Transaction() { }
    public Transaction(int tid, double tamt, DateTime tdate)
    {
        transid = tid;
        transamt = tamt;
        transdate = tdate;
    }


}
public class TransactionManager
{
    int transid;
    double transamt;
    DateTime transdate;
    public TransactionManager()
    { }
    public void createTransactionDetails(Transaction trans)
    {
        this.transid = transid;
        this.transamt = transamt;
        this.transdate = transdate;
    }
    public void showTransactionDetails(Transaction trans)
    {
        Console.WriteLine(trans.transid);
        Console.WriteLine(trans.transamt);
        Console.WriteLine(trans.transdate);
    }
}
public class Transac
{
    public static void Main()
    {

        int tid = Convert.ToInt32(Console.ReadLine());
        double tamt = Convert.ToDouble(Console.ReadLine());
        String s = Console.ReadLine();
        DateTime tdate = DateTime.Parse(s);
        Transaction trans = new Transaction(tid, tamt, tdate);
        TransactionManager tm = new TransactionManager();
        tm.createTransactionDetails(trans);
        tm.showTransactionDetails(trans);
    }
}
