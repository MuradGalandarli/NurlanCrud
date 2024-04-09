using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student.EntityLayer.Course.Entity
{
    public class Course
    {
        [Key]
        public int IdCourse { get; set; }
        public string Name { get; set; }
        public DateTime Duraction  { get; set; }
        public int Price  { get; set; }
        public DateTime CreationTime  { get; set; }
        public DateTime ModificationTime  { get; set; }
        
        public bool IsDeleted { get; set; }
         
       public  List<Student>Students { get; set; }

        public int IdTeacher { get; set; }  
        public Teacher Teacher { get; set; }  



    }
}
