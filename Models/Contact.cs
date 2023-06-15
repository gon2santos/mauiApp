using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Contact
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public int ContactId { get; set; }
        public string number { get; set; }
        public string address { get; set; }

        public Contact(String _name, String _email, int _id, string _number, string _address)
        {
            Name = _name;
            Email = _email;
            ContactId = _id;
            number = _number;
            address = _address;
        }

    }
}
