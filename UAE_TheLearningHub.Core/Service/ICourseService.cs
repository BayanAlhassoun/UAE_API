﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAE_TheLearningHub.Core.Data;

namespace UAE_TheLearningHub.Core.Service
{
    public interface ICourseService
    {
        Task<List<Course>> GetAllCourses();
        Task<Course> GetCourseById(int id);
        Task CreateCourse(Course course);

        Task UpdateCourse(Course course);

        Task DeleteCourse(int id);
    }
}
