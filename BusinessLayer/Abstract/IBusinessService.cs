using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBusinessService
    {
        void Insert(Business business);
        void Update(Business business);
        void Remove(Business business);
        List<Business> GetAll();
        Business Get(int id);
    }
}
