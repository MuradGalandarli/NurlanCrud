using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Bsiness.Abstract;
using Student.EntityLayer.Course.Entity;

namespace ApiStudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherManager teacher;  
        public TeacherController(ITeacherManager teacher)
        {
            this.teacher = teacher;
        }

        [HttpPost]
        public Teacher AddTeacher([FromBody] Teacher teacher)
        {
            this.teacher.Add(teacher);   
            return teacher;
        }



    }
}
