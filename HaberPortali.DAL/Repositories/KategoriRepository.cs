using HaberPortali.Core.DataAccess.BaseClass.EntityFramework;
using HaberPortali.DAL.IRepositories;
using HaberPortali.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.DAL.Repositories
{
    public class KategoriRepository : EFRepositoryBase<Kategori, int, HaberContext>, IKategoriRepository
    {
        public KategoriRepository() : base(new HaberContext())
        {

        }
    }
}
