using HaberPortali.BLL.IServices;
using HaberPortali.BLL.Services;
using HaberPortali.DAL.Repositories;
using HaberPortali.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.BLL.Controller
{
    public class YorumController : ServicesBase<Yorum, int>, IYorumServices
    {
        public YorumController() : base(new YorumRepository())
        {

        }
    }
}
