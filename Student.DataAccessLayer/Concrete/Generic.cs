using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Student.DataAccessLayer.Abstract;
using Student.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DataAccessLayer.Concrete
{
    public class Generic<T> : IGeneric<T> where T : class
    {
        IConfiguration configuration;

        ApplicationDbContext context;
        public Generic(ApplicationDbContext context) 
        {
          this.context = context;
        }
       
        public T Add(T t)
        {
           context.Set<T>().Add(t);
            context.SaveChanges();
            return t;
        }

        public List<T> AllList()

        {
            var studsents = context.Set<T>().ToList();
            return studsents;
        }

        public void Delete(int id)
        {
           var result = context.Set<T>().Find(id);
            context.Set<T>().Remove(result);
            context.SaveChanges();
        }

        public T GetListById(int id)
        { 
           return context.Set<T>().Find(id);  
        }

       

        public T Update(T t)
        {
             context.Set<T>().Update(t);
            context.SaveChanges();
            return t;
        }
    }
}
