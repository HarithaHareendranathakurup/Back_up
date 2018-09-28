using System;

public class Contactinfo
{
    public string address;
    public string state;
    public string country;
    public string city;
    public string phonenum;
    public string mobilenum;
    public string emailid;



    public Contactinfo(string ad, string st, string co, string ct, string pno, string mno, string eid)
    {
        address = ad;
        state = st;
        country = co;
        city = ct;
        phonenum = pno;
        mobilenum = mno;
        emailid = eid;

    }


}
public class ContactinfoManager
{

    public string address;
    public string state;
    public string country;
    public string city;
    public string phonenum;
    public string mobilenum;
    public string emailid;
    public ContactinfoManager()
    { }
    public void createContact(Contactinfo contact)
    {
        this.address = address;
        this.state = state;
        this.country = country;
        this.city = city;
        this.phonenum = phonenum;
        this.mobilenum = mobilenum;
        this.emailid = emailid;


    }
    public void displayContactDetails(Contactinfo contact)
    {
        Console.WriteLine(contact.address);
        Console.WriteLine(contact.state);
        Console.WriteLine(contact.country);
        Console.WriteLine(contact.city);
        Console.WriteLine(contact.phonenum);
        Console.WriteLine(contact.mobilenum);
        Console.WriteLine(contact.emailid);

    }
}
public class Contact
{
    public static void Main()
    {
        string ad = Console.ReadLine();
        string st = Console.ReadLine();
        string co = Console.ReadLine();
        string ct = Console.ReadLine();
        string pno = Console.ReadLine();
        string mno = Console.ReadLine();
        string eid = Console.ReadLine();
        Contactinfo c = new Contactinfo(ad, st, co, ct, pno, mno, eid);
        ContactinfoManager cm = new ContactinfoManager();
        cm.createContact(c);
        cm.displayContactDetails(c);
    }
}

