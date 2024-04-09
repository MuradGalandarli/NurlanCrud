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
    public class ReposiyoryEFTeacherDal:Generic<Teacher>,IRepositoryEFTeacher
    {
        private readonly ApplicationDbContext context;
        public ReposiyoryEFTeacherDal(ApplicationDbContext contetx):base(contetx) 
        {
            this.context = contetx; 
        }
    }
}
