using Student.Bsiness.Abstract;
using Student.DataAccessLayer.Abstract;
using Student.DataAccessLayer.RepositoryEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Bsiness.Concrete
{
    public class StudentManager : IStudentManagercs
    {
        private readonly IRepositoryEFStudent _student;

            public StudentManager(IRepositoryEFStudent student)
        {
            _student = student;
        }

        public EntityLayer.Course.Entity.Student Add(EntityLayer.Course.Entity.Student student)
        {
            student.IsDeleted = true;
           return _student.Add(student);

        }

        public List<EntityLayer.Course.Entity.Student> AllList()
        {
           
           return _student.GetAllListTrue();
        }

        public void Delete(int id)
        {
            _student.DeleteFalse(id);        }

        public EntityLayer.Course.Entity.Student GetListById(int id)
        {
            var result = _student.GetListById(id);
            if (result.IsDeleted == true) {
                return result;
            }
            return default;
        }

        public EntityLayer.Course.Entity.Student Update(EntityLayer.Course.Entity.Student student)
        {
            student.IsDeleted = true;
           return _student.Update(student);
        }
    }
}
