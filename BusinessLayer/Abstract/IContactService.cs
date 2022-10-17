using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        void Insert(Contact contact);
        void Update(Contact contact);
        void Remove(Contact contact);
        List<Contact> GetAll();
        Contact Get(int id);
    }
}
