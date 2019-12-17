using HaberPortali.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Entity.Model
{
    public class Yazar : IEntity
    {
        public Yazar()
        {
            Haberler = new HashSet<Haber>();

            //Yorumlar = new HashSet<Yorum>();

            Kategoriler = new HashSet<Kategori>();
        }

        public int YazarId { get; set; }

        public string YazarAd { get; set; }

        public string YazarSoyad { get; set; }

        public string Email { get; set; }

        public string Sifre { get; set; }

        public bool AktifMi { get; set; }

        public Rol Rolu { get; set; }




        public int? HaberId { get; set; }
        public virtual ICollection<Haber> Haberler { get; set; }

        //public int YorumId { get; set; }
        //public virtual ICollection<Yorum> Yorumlar { get; set; }

        public int? KategoriId { get; set; }
        public virtual ICollection<Kategori> Kategoriler { get; set; }

    }
}
