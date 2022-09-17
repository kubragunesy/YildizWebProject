using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMediaService
    {
        void Insert(Media media);
        void Update(Media media);
        void Remove(Media media);
        List<Media> GetAll();
        Media Get(int id);
    }
}
