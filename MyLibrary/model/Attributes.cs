using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.model
{
    [Serializable]
    public class Attributes
    {
        public string Key { get; set; }
        public bool Value { get; set; }
        public Attributes(string key, bool value)
        {
            Key = key;
            Value = value;
        }
        public Attributes() { }
    }
}
