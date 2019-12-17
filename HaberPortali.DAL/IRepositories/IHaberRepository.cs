using HaberPortali.Core.DataAccess.IBaseRepository;
using HaberPortali.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.DAL.IRepositories
{
    public interface IHaberRepository : IRepository<Haber, int>
    {
    }
}
