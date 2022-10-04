
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public Contact Get(int id)
        {
            return _contactDal.GetById(b=>b.customerId == id);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetList();
        }

        public void Insert(Contact contact)
        {
            contact.statu = true;
            _contactDal.Insert(contact);
        }

        public void Remove(Contact contact)
        {
            _contactDal.Remove(contact);
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
