using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelmanage
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel ho = new Hotel();
            HotelManager h = new HotelManager();
            ho.hotelId = 1;
            ho.briefNote = "jmjh";
            ho.hotelName = "Champa";
            ho.photoURL = "hjjbv";
            ho.starRanking = 5;
            h.storedata(ho);
            h.showdata(ho);
            Console.ReadKey();
        }
    }
    public class Hotel
    {
        public long hotelId { get; set; }
        public String briefNote { get; set; }
        public String hotelName{get;set;}
        public String photoURL { get; set; }
        public int starRanking { get; set; }

    }
    class HotelManager
    {
        public long hotelId;
        public String briefNote;
        public String hotelName;
        public String photoURL;
        public int starRanking;
        public void storedata(Hotel ho)
        {
            this.hotelId = ho.hotelId;
            this.briefNote = ho.briefNote;
            this.hotelName = ho.hotelName;
            this.photoURL = ho.photoURL;
            this.starRanking = ho.starRanking;
        }
        public void showdata(Hotel ho)
        {
            Console.WriteLine(ho.hotelId);
            Console.WriteLine(ho.briefNote);
            Console.WriteLine(ho.hotelName);
            Console.WriteLine(ho.photoURL);
            Console.WriteLine(ho.starRanking);

        }
    }
}
