using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UAE_TheLearningHub.Core.Data;
using UAE_TheLearningHub.Core.Service;

namespace UAE_TheLearningHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {

        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public async Task CraeteCourse(Course course) // MVC=> localhost/port/controller/action : localhost/2400/Course/CreateCourse
        {
            await _courseService.CreateCourse(course); // API=> localhost/port/API/Course => post
        }

        [HttpPut]
        public async Task UpdateCourse(Course course) // MVC=> localhost/port/Course/UpdateCourse
        {
            await _courseService.UpdateCourse(course); // API=> localhost/port/API/Course => put
        }


        [HttpDelete ("{id}")]

        public async Task DeleteCourse(int id) // API => localhost/port/API/Course/2 => delete
        {
            await _courseService.DeleteCourse(id);
        }

        [HttpGet]
        public async Task<List<Course>> GetAllCourses() // API=> localhost/port/Api/Course => Get
        {
           return await _courseService.GetAllCourses();
        }

        [HttpGet]
        [Route ("GetById/{id}")]
        public async Task<Course> GetCourseById(int id) // API=> localhost/port/APi/Course/GetById/2 => Get
        {
            return await _courseService.GetCourseById(id);
        }
    }
}
