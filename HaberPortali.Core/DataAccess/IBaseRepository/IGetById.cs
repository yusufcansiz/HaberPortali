using HaberPortali.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Core.DataAccess.IBaseRepository
{
    public interface IGetById<TEntity, TKey> where TEntity : class, IEntity, new()
    {
        TEntity GetById(TKey id);

        //TEntity yerine mesela Kategori entity tipini verdik. TKey yerine de int tipini verdigimizde
        //Kategori GetById(int id)
    }
}
