using Student.DataAccessLayer.Abstract;
using Student.DataAccessLayer.Concrete;
using Student.EntityLayer.Course.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccessLayer.RepositoryEF
{
    public class RepositoryEFCourseDal:Generic<Course>,IRepositoryEFCourse
    {
        public RepositoryEFCourseDal(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
