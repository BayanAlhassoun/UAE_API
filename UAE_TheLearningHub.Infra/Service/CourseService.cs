using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAE_TheLearningHub.Core.Data;
using UAE_TheLearningHub.Core.DTO;
using UAE_TheLearningHub.Core.Repository;
using UAE_TheLearningHub.Core.Service;

namespace UAE_TheLearningHub.Infra.Service
{
    public class CourseService: ICourseService
    { 
        private readonly ICourseRepository _courseRepository; // ICourseRepository _courseRepository = new CourseRepository();

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task CreateCourse(Course course)
        {
           await _courseRepository.CreateCourse(course);
        }

        public async Task DeleteCourse(int id)
        {
          await  _courseRepository.DeleteCourse(id);
        }

        public async Task<List<Course>> GetAllCourses()
        {
            return await _courseRepository.GetAllCourses();
        }

        public async Task<Course> GetCourseById(int id)
        {
           return await _courseRepository.GetCourseById(id);

        }

        public List<Search> SearchByRegisterdDate(DateTime RegisterdDate)
        {
            return _courseRepository.SearchByRegisterdDate(RegisterdDate);
        }

        public async Task UpdateCourse(Course course)
        {
             await _courseRepository.UpdateCourse(course);
        }
    }
}
