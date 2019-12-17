using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Core.DataAccess.IBaseRepository
{
    public interface IGetExp<T> where T : class, new()
    {
        //birsey yoksa da null
        List<T> Get(Expression<Func<T, bool>> exp = null);
    }
}
