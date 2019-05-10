namespace Hotel.App
{
    using System;
    using System.Collections.Generic;

    public class HotelManager
    {
        public HotelManager()
        {
            this.Hotels = new List<Hotel>();
        }

        public List<Hotel> Hotels { get; set; }

        public void Add(Hotel hotel)
        {
            this.Hotels.Add(hotel);
        }

        public void Delete(Hotel hotel)
        {
            //todo - implement
        }

        public void FindRoom(int amount)
        {
            //todo - implement

            foreach (var hotel in this.Hotels)
            {
                foreach (var hotelRoom in hotel.Rooms)
                {
                    if (hotelRoom.Rate.Amount < amount)
                    {
                        Console.WriteLine($"Find room: {hotelRoom.Number} from hotel {hotel.Name}. Price: {hotelRoom.Rate.Amount}" );
                    }
                }
            }
        }
    }
}