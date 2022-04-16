using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.BusinessInterface
{
    public interface IOrderPlaceHeaderRepository<T,ID>
    {
        void Add(T e);
        bool Delete(ID id);
    }
}
