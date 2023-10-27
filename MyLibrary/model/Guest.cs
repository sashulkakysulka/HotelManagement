using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyLibrary.model
{
    [Serializable]
    public class Guest : Person
    {
        public string Notes { get; set; }
        public List<int> ReservedRooms { get; set; }
        public List<> Reserwations { get; set; }
        public Guest(string name, string surname, string nationality,
            DateTime dateofbirth, string documenttype, string documentnumber, string notatki, List<int> reservedrooms, List<> reservations)
       : base(name, surname, nationality, dateofbirth, documenttype, documentnumber)
        {
            Notes = notatki;
            ReservedRooms = reservedrooms;
            Reserwations = reservations;
        }
        public Guest() { }
    }
}
