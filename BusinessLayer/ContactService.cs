using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ContactService
    {
        public static ContactService Instancia { get; } = new ContactService();
        public void add(Contact item)
        {
            ContactRepository.Instancia.contacts.Add(item);
        }
        public void Edit(int Index , Contact item)
        {
            ContactRepository.Instancia.contacts[Index]=item;
        }
        public void Delelte(int Index)
        {
            ContactRepository.Instancia.contacts.RemoveAt(Index);
        }
        public Contact Getitem(int Index)
        {
            return ContactRepository.Instancia.contacts[Index];
        }
        public List<Contact> GetAll ()
        {
            return ContactRepository.Instancia.contacts;
        }
    }
}
