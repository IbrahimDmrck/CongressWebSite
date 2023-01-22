using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISaveService
    {
        void Add(Save save);
        void Delete(Save save);
        void Update(Save save);
        List<Save> GetAll();
        Save GetById(int id);
    }
}
