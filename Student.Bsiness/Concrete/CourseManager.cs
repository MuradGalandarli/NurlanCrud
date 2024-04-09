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
    public class CourseManager : ICourseManager
    {
        private readonly IRepositoryEFCourse repositoryEFCourse;
        public CourseManager(IRepositoryEFCourse repositoryEFCourse)
        {
            this.repositoryEFCourse = repositoryEFCourse;
        }

        public Course Add(Course t)
        {
            return repositoryEFCourse.Add(t);
        }

        public List<Course> AllList()
        {
            return repositoryEFCourse.AllList();
        }

        public void Delete(int id)
        {
            repositoryEFCourse.Delete(id);
        }

        public Course GetListById(int id)
        {
            return repositoryEFCourse.GetListById(id);
        }

        public Course Update(Course t)
        {
          return repositoryEFCourse.Update(t);  
        }
    }
}
