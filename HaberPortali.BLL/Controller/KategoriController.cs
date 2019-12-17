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
    public class KategoriController  : ServicesBase<Kategori, int>, IKategoriServices
    {
        public KategoriController() : base(new KategoriRepository())
        {

        }
    }
}
