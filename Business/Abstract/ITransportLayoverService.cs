using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransportLayoverService
    {
        void Add(TransportLayover transportLayover);
        void Delete(TransportLayover transportLayover);
        void Update(TransportLayover transportLayover);
        List<TransportLayover> GetAll();
        TransportLayover GetById(int id);
    }
}
