using Student.DataAccessLayer.Abstract;
using Student.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccessLayer.RepositoryEF
{
    public class RepositoryEFStudentDal : Generic<EntityLayer.Course.Entity.Student>, IRepositoryEFStudent
    {
        ApplicationDbContext context;
        public RepositoryEFStudentDal(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public void DeleteFalse(int id)
        {
            var a = context.Studsents.Find(id);
            a.IsDeleted = false;
        context.SaveChanges();
        }

        public List<EntityLayer.Course.Entity.Student> GetAllListTrue()
        {
           return context.Studsents.Where(x => x.IsDeleted == true).ToList();
        }
    }
}
