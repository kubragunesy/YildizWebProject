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
    public class CompanyInfoManager:ICompanyInfoService
    {
        ICompanyInfoDal _companyInfoDal;
        public CompanyInfoManager(ICompanyInfoDal companyInfoDal)
        {
            _companyInfoDal = companyInfoDal;
        }

        public CompanyInfo Get(int id)
        {
            return _companyInfoDal.GetById(x=>x.Id==id);
        }

        public List<CompanyInfo> GetAll()
        {
            return _companyInfoDal.GetList();
        }

        public void Insert(CompanyInfo companyInfo)
        {
<<<<<<< HEAD
           _companyInfoDal.Insert(companyInfo);
=======
            _companyInfoDal.Insert(companyInfo);
>>>>>>> 4e0c6bad3e176ac282620790ddaa6ba8f7adfce3
        }

        public void Remove(CompanyInfo companyInfo)
        {
            _companyInfoDal.Remove(companyInfo);
        }

        public void Update(CompanyInfo companyInfo)
        {
            _companyInfoDal.Update(companyInfo);
        }
    }
}
