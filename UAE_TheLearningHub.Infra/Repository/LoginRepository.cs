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
    public class LoginRepository : ILoginRepository
    {
        private readonly IDbContext _dbContext;

        public LoginRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Login Login(Login login)
        {
            var p = new DynamicParameters();
            p.Add("User_name", login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pass", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Query<Login>("Login_Package.Login", p, commandType: CommandType.StoredProcedure);        
            return result.FirstOrDefault();
        }
    }
}
