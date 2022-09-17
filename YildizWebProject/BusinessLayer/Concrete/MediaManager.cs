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
    public class MediaManager : IMediaService
    {
        IMediaDal _mediaDal;
        public MediaManager(IMediaDal mediaDal)
        {
            _mediaDal = mediaDal;
        }
        public Media Get(int id)
        {
            return _mediaDal.GetById(b=>b.mediaId == id);
        }

        public List<Media> GetAll()
        {
            return _mediaDal.GetList();
        }

        public void Insert(Media media)
        {
            _mediaDal.Insert(media);
        }

        public void Remove(Media media)
        {
            _mediaDal.Remove(media);
        }

        public void Update(Media media)
        {
            _mediaDal.Update(media);
        }
    }
}
