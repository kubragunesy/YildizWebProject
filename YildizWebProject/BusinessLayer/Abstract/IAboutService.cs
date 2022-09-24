using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        void Insert(About about);
        void Update(About about);
        void Remove(About about);
        List<About> GetAll();
        About Get(int id);
    }
}
