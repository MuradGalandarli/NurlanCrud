using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.EntityLayer.Course.Entity
{
    public class Teacher
    {
        [Key]
        public int IdTeacher { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public  int BirtDate { get; set; }
        public  int Profession { get; set; }
        public bool IsDeleted { get; set; }
        public List<Course> Course { get; set; }

    }
}
