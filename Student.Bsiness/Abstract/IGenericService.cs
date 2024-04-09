using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Bsiness.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> AllList();
        T GetListById(int id);

        T Update(T t);

        void Delete(int id);

        T Add(T t);
    }
}
