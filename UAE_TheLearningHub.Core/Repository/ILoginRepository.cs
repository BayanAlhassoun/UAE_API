using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAE_TheLearningHub.Core.Data;

namespace UAE_TheLearningHub.Core.Repository
{
    public interface ILoginRepository
    {
      Login Login(Login login);
    }
}
