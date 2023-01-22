using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAnnouncementService
    {
        void Add(Announcement announcement);
        void Delete(Announcement announcement);
        void Update(Announcement announcement);
        List<Announcement> GetAll();
        Announcement GetById(int id);
    }
}
