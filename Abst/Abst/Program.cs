using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abst
{
    abstract class Room
    {
        int roomno;
        int floorno;
        double cost;

    }
    class ConferenceRoom:Room
    {
        int noOfChairs;
        int noWhiteboards;
        int noOfProjector;
    }
    class GuestRoom:Room
    {
        int noOfBeds;
        bool extraBedAllowed;
        string rooomType;


    }
    class RoomManager
    {
        public void Bookroom()
        {

        }
        public void Showroom()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
