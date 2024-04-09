using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccessLayer.Abstract
{
    public interface IRepositoryEFStudent:IGeneric<EntityLayer.Course.Entity.Student>
    {
        public List<EntityLayer.Course.Entity.Student> GetAllListTrue();

        public void DeleteFalse (int id);
     }
}
