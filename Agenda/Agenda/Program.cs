using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {           
            var ag = new List<Contact>
            {
            new Contact { FirstName = "Gigi", LastName = "Duru"},
            new Contact { FirstName = "Floricica", LastName = "Dansatoarea", Address = "peste tot", Email = "flo@dans.ro", Nickname = "floricica", PhoneNumber = "0754566655" },
            new Contact { FirstName = "Lala", LastName = "Land" },
            new Contact { FirstName = "Flori", LastName = "Duru" },
            new Contact { FirstName = "Florina", LastName = "Duru" },
            new Contact { FirstName = "Alta", LastName = "Flo" },
            new Contact { FirstName = "Lili", LastName = "Lu" }
            };
            var agenda = new Agenda { ContactList = ag };


            agenda.Search("flo");

            Console.Read();

        }      
    }
}
