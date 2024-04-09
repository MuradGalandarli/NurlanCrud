using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Bsiness.Abstract;

namespace ApiStudent.Controllers
{
 //   [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentManagercs studentManager;
        public StudentController(IStudentManagercs managercs)
        {
            studentManager = managercs;
        }
        [Route("Add/[controller]")]
        [HttpPost]
        public Student.EntityLayer.Course.Entity.Student AddStudent([FromBody] Student.EntityLayer.Course.Entity.Student student)
        {
            return studentManager.Add(student);
        }

        [HttpDelete("Delete/[controller]/{id}")]
        public void DeleteStudent(int id)
        {
            studentManager.Delete(id);
        }
          [HttpGet("GetId/[controller]/{id}")]
          public Student.EntityLayer.Course.Entity.Student GetId(int id)
          {
              return studentManager.GetListById(id);
          }

          [Route("Update/[controller]")]
          [HttpPut]
          public Student.EntityLayer.Course.Entity.Student Update(Student.EntityLayer.Course.Entity.Student student)
          {
              return studentManager.Update(student);
          }
          [Route("Get/[controller]")]
          [HttpGet]
          public List<Student.EntityLayer.Course.Entity.Student> AllList()
          {
              return studentManager.AllList();
          }

    }
}
