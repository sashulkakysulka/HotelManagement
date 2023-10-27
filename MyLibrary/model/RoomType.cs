using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyLibrary.model
{
    [Serializable]
    public class RoomType
    {
        public int NumberOfPeopleAllowed { get; set; }
        public int NunmberOfKidsAllowed { get; set; }
        [XmlElement(ElementName ="Atrybuty")]
        public List<Attributes> Attributes;
        public RoomType(params bool[] values)
        {
            Attributes = new List <Attributes>();

            List<string> attributesnames = GetFilters();
            for (int i = 0; i < values.Length && i < attributesnames.Count; i++)
            {
                Attributes.Add(new Attributes(attributesnames[i], values[i]));
            }
        }
        public RoomType() { }
        public List<string> GetFilters()
        {
            List<string> filters = new List<string>();
            filters.Add("Standart");
            filters.Add("Luxe");
            filters.Add("Deluxe");
            filters.Add("Smoking Friendly");
            filters.Add("Pet Friendly");
            return filters;
        }
       
    }
}