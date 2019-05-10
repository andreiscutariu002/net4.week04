using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.App
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var hotelManager = new HotelManager();

            var hotel = new Hotel("Hotel 1", "Iasi");

            hotel.Rooms = new List<Room>();

            var rate = new Rate(100, "RON");
            var room = new Room(1, 2, 0, rate);

            var rate2 = new Rate(80, "RON");
            var room2 = new Room(2, 1, 0, rate2);

            var rate3 = new Rate(50, "RON");
            var room3 = new Room(3, 1, 0, rate3);

            hotel.Rooms.Add(room);
            hotel.Rooms.Add(room2);
            hotel.Rooms.Add(room3);

            // 1. Add new hotel
            hotelManager.Add(hotel);


            hotelManager.Delete(hotel);

            // 3. Find room
            hotelManager.FindRoom(120);
        }
    }
}
