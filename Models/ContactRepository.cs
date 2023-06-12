using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>() {
            new Contact("Gonzalo Dos Santos Necchi", "necchigonzalo@gmail.com"),
            new Contact("Claudia Silvia Necchi", "csnecchi@gmail.com"),
            new Contact("Alejandro Dos Santos", "aledosn@gmail.com")
        };

        public static List<Contact> GetAllContacts() {
            return _contacts;
        }

        public static Contact GetContact(int id)
        {
            return _contacts.FirstOrDefault(x => x.ContactId == id);
        }
    }
}
