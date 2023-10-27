using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.model
{
    [Serializable]
    public class Room
    {
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public decimal PricePerNight { get; set; }
        public RoomType RoomType { get; set; }       
        public List<> Reservations { get; set; }

        public Room(int roomnumber, int floor, decimal pricepernight,
            RoomType roomtype, List<> reservations)
        {
            RoomNumber = roomnumber;
            Floor = floor;
            RoomType = roomtype;
            Reservations = reservations;
            PricePerNight = pricepernight;
        }
        public Room() { }
    }
}
