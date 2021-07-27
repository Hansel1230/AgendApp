using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public sealed class ContactRepository
    {
        public static ContactRepository Instancia { get; } = new ContactRepository();

        public List<Contact> contacts { get; set; } = new List<Contact>();

        private ContactRepository()
        {

        }
    }

    
}
