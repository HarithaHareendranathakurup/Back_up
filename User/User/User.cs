using System;

public class User
{
    public int userId;
    public string dateOfBirth;
    public string userName;
    public string guardianName;

    public User(int uid, string dob, string un, string gn)
    {
        userId = uid;
        dateOfBirth = dob;
        userName = un;
        guardianName = gn;
    }

}
public class UserManager
{
    int userId;
    string dateOfBirth;
    string userName;
    string guardianName;
    public UserManager()
    { }
    public void createUser(User user)
    {
        this.userId = user.userId;
        this.dateOfBirth = user.dateOfBirth;
        this.userName = user.userName;
        this.guardianName = user.guardianName;


    }
    public void showUserDetails(User user)
    {
        Console.WriteLine(user.userId);
        Console.WriteLine(user.dateOfBirth);
        Console.WriteLine(user.userName);
        Console.WriteLine(user.guardianName);

    }
}
public class Manager
{
    public static void Main()
    {
        int uid = Convert.ToInt32(Console.ReadLine());
        string dob = Console.ReadLine();
        string un = Console.ReadLine();
        string gn = Console.ReadLine();
        User u = new User(uid, dob, un, gn);
        UserManager um = new UserManager();
        um.createUser(u);
        um.showUserDetails(u);
    }
}
