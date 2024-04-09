using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Bsiness.Abstract;
using Student.EntityLayer.Course.Entity;
using System.Diagnostics.Contracts;

namespace ApiStudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
       private readonly  ICourseManager courseManager;
        public CourseController(ICourseManager courseManager)
        {
            this.courseManager = courseManager;
        }

     //   [Route("Get1/[controller]")]
        [HttpGet]
        public List<Course> GetAllListCourse() 
        {
           return courseManager.AllList();
        }

        [HttpPost]
        public Course Add([FromBody] Course course)
        { 
             courseManager.Add(course);   
             return course;      
        }




    }
}
