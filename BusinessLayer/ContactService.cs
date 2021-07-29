using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataPersistence; 

namespace BusinessLayer
{
    public class ContactService
    {
        public static ContactService Instancia { get; } = new ContactService();

        private Serializer serializer;
        private string Directory;
        private string FileName;

        public ContactService()
        {
            serializer = new Serializer();
            Directory = "Contact";
            FileName = "Contact.binary";
        }

        #region Methods
        public void add(Contact item)
        {
            ContactRepository.Instancia.Contacts.Add(item);
            serializer.serialize(ContactRepository.Instancia.Contacts,Directory,FileName);
        }
        public void Edit(int Index , Contact item)
        {
            ContactRepository.Instancia.Contacts[Index]=item;
            serializer.serialize(ContactRepository.Instancia.Contacts, Directory, FileName);

        }
        public void Delelte(int Index)
        {
            ContactRepository.Instancia.Contacts.RemoveAt(Index);
            serializer.serialize(ContactRepository.Instancia.Contacts, Directory, FileName);

        }
        public Contact Getitem(int Index)
        {
            return ContactRepository.Instancia.Contacts[Index];

        }
        public List<Contact> GetAll ()
        {
            
            List<Contact> contacts = (List<Contact>)serializer.Deserialize(Directory, FileName);

            if (contacts !=null)
            {
                
                ContactRepository.Instancia.Contacts =contacts;
            }
            
            return ContactRepository.Instancia.Contacts;
        }
        #endregion
    }
}
