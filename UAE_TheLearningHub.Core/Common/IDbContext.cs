using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAE_TheLearningHub.Core.Common
{
    public interface IDbContext
    {
        public DbConnection Connection { get; }
    }
}
