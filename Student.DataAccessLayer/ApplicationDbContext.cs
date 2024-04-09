using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Student.EntityLayer.Course.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

  public DbSet<Student.EntityLayer.Course.Entity.Student> Studsents { get; set; }
    public DbSet<Course> Courses { get; set; } 

    public DbSet<Teacher>Teachers { get; set; }
}
