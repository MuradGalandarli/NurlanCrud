using Student.Bsiness.Abstract;
using Student.DataAccessLayer.Abstract;
using Student.EntityLayer.Course.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Bsiness.Concrete
{
    public class TeacherManager : ITeacherManager
    {
        private readonly IRepositoryEFTeacher teacher;
        public TeacherManager(IRepositoryEFTeacher Teacher)
        {
            teacher = Teacher;
        }

        public Teacher Add(Teacher t)
        {
            return teacher.Add(t);  
        }

        public List<Teacher> AllList()
        {
           return teacher.AllList();
        }

        public void Delete(int id)
        {
            teacher.Delete(id);
        }

        public Teacher GetListById(int id)
        {
           return teacher.GetListById(id);
        }

        public Teacher Update(Teacher t)
        {
            return teacher.Update(t);   
        }
    }
}
