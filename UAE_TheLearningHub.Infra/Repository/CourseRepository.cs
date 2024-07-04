using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAE_TheLearningHub.Core.Common;
using UAE_TheLearningHub.Core.Data;
using UAE_TheLearningHub.Core.Repository;

namespace UAE_TheLearningHub.Infra.Repository
{
    public class CourseRepository : ICourseRepository
    {

        private readonly IDbContext _dbContext;

        public CourseRepository(IDbContext dbContext) // IDbContext dbContext = new DbContext()
        {
            _dbContext = dbContext; // _dbContext = new DbContext()
        }

        public async Task CreateCourse(Course course)
        {
            var p =new DynamicParameters();
            p.Add("course_name", course.Coursename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("image_name", course.Imagename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("category_id", course.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            await _dbContext.Connection.ExecuteAsync("Course_Package.CreateCourse", p, commandType: CommandType.StoredProcedure);
           
        }

        public async Task DeleteCourse(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
           await _dbContext.Connection.ExecuteAsync("Course_Package.DeleteCourse", p, commandType: CommandType.StoredProcedure);
        }

        public async Task<List<Course>> GetAllCourses()
        {
            var result = await _dbContext.Connection.QueryAsync<Course>("Course_Package.GetAllCourses", commandType: CommandType.StoredProcedure);
           
            return result.ToList();
        }

        public async Task<Course> GetCourseById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await _dbContext.Connection.QueryAsync<Course>("Course_Package.GetCourseById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public async Task UpdateCourse(Course course)
        {
            var p = new DynamicParameters();
            p.Add("course_id", course.Courseid, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("course_name", course.Coursename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("image_name", course.Imagename, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("category_id", course.Categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
           await _dbContext.Connection.ExecuteAsync("Course_Package.UpdateCourse", p, commandType: CommandType.StoredProcedure);
        }
    }
}
