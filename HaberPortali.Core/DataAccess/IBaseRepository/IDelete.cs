﻿using HaberPortali.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Core.DataAccess.IBaseRepository
{
    public interface IDelete<TEntity> where TEntity : class, IEntity, new()
    {
        int Delete(TEntity entity);
    }
}
