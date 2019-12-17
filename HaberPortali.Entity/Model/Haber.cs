using HaberPortali.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Entity.Model
{
    public class Haber : IEntity
    {
        public Haber()
        {
            Yorumlar = new HashSet<Yorum>();

            Kategoriler = new HashSet<Kategori>();
        }

        public int HaberId { get; set; }

        public string HaberBaslik { get; set; }

        public string HaberOzet { get; set; }

        public string HaberDetay { get; set; }

        public DateTime YayinlanmaTarihi { get; set; }

        public bool AktifMi { get; set; }

        public bool PopulerMi { get; set; }

        public int? GoruntulenmeSayisi { get; set; }

        public int? BegenmeSayisi { get; set; }


        public int? YazarId { get; set; }
        public virtual Yazar Yazar { get; set; }

        public int? YorumId { get; set; }
        public virtual ICollection<Yorum> Yorumlar { get; set; }

        public int? FotografId { get; set; }
        public virtual ICollection<Fotograf> Fotograf { get; set; }

        public int? KategoriId { get; set; }
        public virtual ICollection<Kategori> Kategoriler { get; set; }


    }
}
