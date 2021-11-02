using System;
using System.Linq;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Array.Sort(persons);

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(persons[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 7; i >= 0; i--)
            {
                Console.WriteLine(persons[i]);
            }
        }
        
        public static Person[] persons = new Person[8] 
        {
            new Person("Анастасия", "Петрова", new DateTime(1976, 2, 6)),
            new Person("Евгения", "Ерофеева", new DateTime(1981, 3, 2)),
            new Person("Егор", "Дементьев", new DateTime(1980, 11, 28)),
            new Person("Ярослав", "Афанасьев", new DateTime(1979, 11, 16)),
            new Person("Анастасия", "Петрова", new DateTime(1982, 3, 10)),
            new Person("Виктория", "Ильина", new DateTime(1987, 5, 21)),
            new Person("Полина", "Волкова", new DateTime(2007, 10, 4)),
            new Person("Ярослав", "Игнатов", new DateTime(2010, 1, 12))
        };
    }
}
