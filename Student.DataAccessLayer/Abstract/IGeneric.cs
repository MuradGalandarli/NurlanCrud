using Student.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccessLayer.Abstract
{
    public interface IGeneric<T> where T:class
    {
        List<T> AllList();
        T GetListById(int id);

        T Update(T t);

        void Delete(int id);

        T Add(T t);
    }
}
