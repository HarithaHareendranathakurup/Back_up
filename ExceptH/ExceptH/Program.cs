using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptH
{
    class Program
    {
        static void Main(string[] args)
        {
            long userId = long.Parse(Console.ReadLine());
             string createdDate=Console.ReadLine();
             string dateOfBirth=Console.ReadLine();
            string fullName= Console.ReadLine();
             string gender= Console.ReadLine();
            string loginId = Console.ReadLine();
            try
            {
                
                if (loginId.Length < 5)
                    throw new InvalidLoginIdException();
            }
            catch(InvalidLoginIdException ex)
            {
                Console.WriteLine("Please enter a valid login id");
            }
            string username= Console.ReadLine();
            string password = Console.ReadLine();
            try
            {
                
                if (password.Length < 5)
                    throw new InvalidPasswordException();
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine("Please enter a valid login id");
            }
            
            User u1= new User(userId,createdDate,dateOfBirth,fullName,gender,loginId,username,password);
            UserManager um1 = new UserManager();

        }
    }
    class User
    {
        public long userId;
        public string createdDate;
        public string dateOfBirth;
        public string fullName;
        public string gender;
        public string loginId;
        public string username;
        public string password;
        public User(long userId,string createdDate,string dateOfBirth,string fullName, string gender, string loginId,string username,string password)
        {
            this.userId = userId;
            this.createdDate = createdDate;
            this.dateOfBirth = dateOfBirth;
            this.fullName = fullName;
            this.gender = gender;
            this.loginId = loginId;
            this.username = username;
            this.password = password;
        }

    }
    class UserManager
    {
        public long userId;
        public string createdDate;
        public string dateOfBirth;
        public string fullName;
        public string gender;
        public string loginId;
        public string username;
        public string password;
        public void StoreData(User u1)
        {
            this.userId = u1.userId;
            this.createdDate =u1.createdDate;
            this.dateOfBirth = u1.dateOfBirth;
            this.fullName = u1.fullName;
            this.gender = u1.gender;
            this.loginId = u1.loginId;
            this.username = u1.username;
            this.password = u1.password;
        }
        public void showData(User u1)
        {
             Console.WriteLine(u1.userId);
             Console.WriteLine(u1.createdDate);
             Console.WriteLine(u1.dateOfBirth);
             Console.WriteLine(u1.fullName);
             Console.WriteLine(u1.gender);
             Console.WriteLine(u1.loginId);
             Console.WriteLine(u1.username);
             Console.WriteLine(u1.password);
        }

    }
    class InvalidLoginIdException : Exception
    {
        public InvalidLoginIdException()
        {

        }
    }
    class InvalidPasswordException : Exception
    {
        public InvalidPasswordException()
        {

        }
    }
}
