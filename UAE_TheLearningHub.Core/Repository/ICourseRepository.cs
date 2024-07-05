using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAE_TheLearningHub.Core.Data;
using UAE_TheLearningHub.Core.DTO;

namespace UAE_TheLearningHub.Core.Repository
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllCourses();
        Task<Course> GetCourseById(int id);
        Task CreateCourse(Course course);

       Task UpdateCourse(Course course);

       Task DeleteCourse(int id);
       List<Search> SearchByRegisterdDate(DateTime RegisterdDate);

    }
}
