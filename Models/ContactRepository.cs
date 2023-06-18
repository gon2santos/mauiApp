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
            new Contact("Gonzalo Dos Santos Necchi", "necchigonzalo@gmail.com", 0, "1133745195", "Arenales 2329"),
            new Contact("Claudia Silvia Necchi", "csnecchi@gmail.com", 1, "1153387164", "Arenales 2329"),
            new Contact("Alejandro Dos Santos", "aledosn@gmail.com", 2, "1530352087", "Arenales 2329")
        };

        public static List<Contact> GetAllContacts()
        {
            return _contacts;
        }

        public static Contact GetContactById(int id)
        {
            var cont = _contacts.FirstOrDefault(x => x.ContactId == id);
            if (cont != null)
                return new Contact(cont.Name, cont.Email, cont.ContactId, cont.number, cont.address);
            return null;
        }

        public static void UpdateContact(int id, Contact contact)
        {
            if (id != contact.ContactId)
                return;

            var contactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == id);
            if (contactToUpdate != null)
            {
                contactToUpdate.Name = contact.Name;
                contactToUpdate.Email = contact.Email;
                contactToUpdate.address = contact.address;
                contactToUpdate.number = contact.number;
            }
        }

        public static void AddContact(Contact contact)
        {
            var maxId = _contacts.Max(x => x.ContactId);
            contact.ContactId = maxId + 1;
            _contacts.Add(contact);
        }

        public static void DeleteContact(Contact contact)
        {
            _contacts.Remove(contact);
        }

        internal static List<Contact> SearchContacts(string text)
        {
            var contacts = _contacts.Where(x => !string.IsNullOrEmpty(x.Name) && x.Name.StartsWith(text, StringComparison.OrdinalIgnoreCase))?.ToList();

            if (contacts == null || contacts.Count == 0)
            {
                contacts = _contacts.Where(x => !string.IsNullOrEmpty(x.Email) && x.Email.StartsWith(text, StringComparison.OrdinalIgnoreCase))?.ToList();
            }
            else return contacts;

            if (contacts == null || contacts.Count == 0)
            {
                contacts = _contacts.Where(x => !string.IsNullOrEmpty(x.number) && x.number.StartsWith(text, StringComparison.OrdinalIgnoreCase))?.ToList();
            }
            else return contacts;
            if (contacts == null || contacts.Count == 0)
            {
                contacts = _contacts.Where(x => !string.IsNullOrEmpty(x.address) && x.address.StartsWith(text, StringComparison.OrdinalIgnoreCase))?.ToList();
            }
            else return contacts;

            return contacts;
        }
    }
}
