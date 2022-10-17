using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCompanyInfoDal:EfGenericDal<CompanyInfo>, ICompanyInfoDal
    {
        //DataAccessLayer.Concrete.Context
    }
}
