using HaberPortali.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Core.DataAccess.IBaseRepository
{
    public interface IDeleteExpression<TEntity> where TEntity : class, IEntity, new()
    {
        int DeleteExp(Expression<Func<TEntity, bool>> exp);
    }
}
