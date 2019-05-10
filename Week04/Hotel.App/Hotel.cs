namespace Hotel.App
{
    using System.Collections.Generic;
    using System.Runtime.Remoting.Metadata.W3cXsd2001;

    public class Hotel
    {
        public Hotel(string name, string city)
        {
            this.Name = name;
            this.City = city;
        }

        public string Name { get; set; }

        public string City { get; set; }

        public List<Room> Rooms { get; set; }
    }
}