using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompanyInfoService
    {
        void Insert(CompanyInfo companyInfo);
        void Update(CompanyInfo companyInfo);
        void Remove(CompanyInfo companyInfo);
        List<CompanyInfo> GetAll();
        CompanyInfo Get(int id);
    }
}
