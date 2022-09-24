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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutdal = aboutDal;
        }
        public About Get(int id)
        {
            return _aboutdal.GetById(m => m.aboutId == id);
        }

        public List<About> GetAll()
        {
            return _aboutdal.GetList();
        }

        public void Insert(About about)
        {
            _aboutdal.Insert(about);
        }

        public void Remove(About about)
        {
            _aboutdal.Remove(about);
        }

        public void Update(About about)
        {
            _aboutdal.Update(about); 
        }
    }
}
