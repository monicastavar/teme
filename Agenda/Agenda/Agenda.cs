using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Agenda
    {
        public List<Contact> ContactList { get; set; }
        //search contact -> contains
        //delete contact
        //filter words

        public IEnumerable<Contact> Search(String filter)
        {
            var lowerFilter = filter.ToLower();
            IEnumerable<Contact> filteredContacts = ContactList
                .Where((n, i) => Contains(n.FirstName,lowerFilter)
                || Contains(n.LastName,lowerFilter)
                || Contains(n.Nickname,lowerFilter));
            
            string value = string.Join(", ", filteredContacts);
            Console.WriteLine(value);
            return filteredContacts;
        }

        private bool Contains(string whatever, string searchString)
        {
            whatever = whatever ?? "";
            return whatever.ToLower().Contains(searchString);
        }

    }    
}
