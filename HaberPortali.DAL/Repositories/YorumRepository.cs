using HaberPortali.Core.DataAccess.BaseClass.EntityFramework;
using HaberPortali.DAL.IRepositories;
using HaberPortali.Entity.Model;

namespace HaberPortali.DAL.Repositories
{
    public class YorumRepository : EFRepositoryBase<Yorum, int, HaberContext>, IYorumRepository
    {
        public YorumRepository() : base(new HaberContext())
        {

        }
    }
}
