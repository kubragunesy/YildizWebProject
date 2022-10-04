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
            throw new NotImplementedException();
        }

        public List<CompanyInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(CompanyInfo companyInfo)
        {
            throw new NotImplementedException();
        }

        public void Remove(CompanyInfo companyInfo)
        {
            throw new NotImplementedException();
        }

        public void Update(CompanyInfo companyInfo)
        {
            throw new NotImplementedException();
        }
    }
}
