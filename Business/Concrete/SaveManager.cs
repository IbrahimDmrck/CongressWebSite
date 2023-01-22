using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SaveManager : ISaveService
    {
        ISaveDal _saveDal;

        public SaveManager(ISaveDal saveDal)
        {
            _saveDal = saveDal;
        }

        public void Add(Save save)
        {
            _saveDal.Add(save);
        }

        public void Delete(Save save)
        {
            _saveDal.Delete(save);
        }

        public List<Save> GetAll()
        {
          return _saveDal.GetAll();
        }

        public Save GetById(int id)
        {
            return _saveDal.GetById(id);
        }

        public void Update(Save save)
        {
            _saveDal.Update(save);
        }
    }
}
