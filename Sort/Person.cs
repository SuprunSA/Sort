using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public class Person : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public int CompareTo(object o)
        {
            Person person = o as Person;
            if (person != null)
            {
                if (Name.CompareTo(person.Name) == 0)
                {
                    if (Surname.CompareTo(person.Surname) == 0)
                    {
                        return BirthDate.CompareTo(person.BirthDate);
                    }
                    else return Surname.CompareTo(person.Surname);
                }
                else return Name.CompareTo(person.Name);
            }
            else throw new ArgumentException("Не явлется объектом класса Person");
        }
        
        public Person(string name, string surname, DateTime dateTime)
        {
            Name = name;
            Surname = surname;
            BirthDate = dateTime;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0,-12}", Name));
            sb.Append(string.Format("{0,-12}", Surname));
            sb.Append(string.Format("{0,12:dd.MM.yyyy}", BirthDate));
            return sb.ToString();
        }
    }
}
