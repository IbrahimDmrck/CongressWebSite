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
    public class TransportLayoverManager : ITransportLayoverService
    {
        ITransportLayoverDal _transportLayover;

        public TransportLayoverManager(ITransportLayoverDal transportLayover)
        {
            _transportLayover = transportLayover;
        }

        public void Add(TransportLayover transportLayover)
        {
            _transportLayover.Add(transportLayover);
        }

        public void Delete(TransportLayover transportLayover)
        {
            _transportLayover.Delete(transportLayover);
        }

        public List<TransportLayover> GetAll()
        {
           return   _transportLayover.GetAll();
        }

        public TransportLayover GetById(int id)
        {
           return _transportLayover.GetById(id);
        }

        public void Update(TransportLayover transportLayover)
        {
            _transportLayover.Update(transportLayover);
        }
    }
}
