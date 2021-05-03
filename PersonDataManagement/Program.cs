using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>() 
            {
                new Person("4578913", "Barack", "Washington", 65),
                new Person("4561333","Donald","NewYork",62),
                new Person("4567895","Sammy","Albama",17),
                new Person("4598962", "Samuel", "NewJersey", 45),
                new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45),
                new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55),
                new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65),
                new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65)
            };

            foreach(var person in personList)
            {
                Console.WriteLine(person.Adress);
            }
            Console.ReadKey();
        }
    }
}
