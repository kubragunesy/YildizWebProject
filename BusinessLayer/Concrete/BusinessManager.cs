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
    public class BusinessManager : IBusinessService
    {
        IBusinessDal _businessdal;
        public BusinessManager(IBusinessDal businessDal)
        {
          _businessdal = businessDal;
        }

        public Business Get(int id)
        {
            return _businessdal.GetById(b => b.businessId == id);
        }

        public List<Business> GetAll()
        {
            return _businessdal.GetList();
        }

        public void Insert(Business business)
        {
            _businessdal.Insert(business);
        }

        public void Remove(Business business)
        {
            _businessdal.Remove(business);
        }

        public void Update(Business business)
        {
            _businessdal.Update(business);
        }
    }
}

        
