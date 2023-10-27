using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyLibrary.model
{
    public abstract class Person
    {     
    private string name;
        private string surname;
        public string Name
        {
            get { return name; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$"))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Imię musi składać się tylko z liter!");
                }
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$"))
                {
                    surname = value;
                }
                else
                {
                    throw new ArgumentException("Nazwisko musi składać się tylko z liter!");
                }
            }
        }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public Person(string name, string surname, string nationality, 
            DateTime dateofbirth, string documenttype, string documentnumber)
        {
            Name = name;
            Surname = surname;
            Nationality = nationality;
            DateOfBirth = dateofbirth;
            DocumentType = documenttype;
            DocumentNumber = documentnumber;
        }
        public Person() { }
    }
}