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
    public class CongressManager : ICongressService
    {
        ICongressDal _congressDal;

        public CongressManager(ICongressDal congressDal)
        {
            _congressDal = congressDal;
        }

        public void Add(Congress congress)
        {
            _congressDal.Add(congress);
        }

        public void Delete(Congress congress)
        {
            _congressDal.Delete(congress);
        }

        public List<Congress> GetAll()
        {
           return  _congressDal.GetAll();
        }

        public Congress GetById(int id)
        {
            return _congressDal.GetById(id);
        }

        public void Update(Congress congress)
        {
            _congressDal.Update(congress);
        }
    }
}
