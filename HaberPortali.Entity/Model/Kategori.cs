using HaberPortali.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Entity.Model
{
    public class Kategori : IEntity
    {
        public Kategori()
        {
            Haberler = new HashSet<Haber>();

            Yazarlar = new HashSet<Yazar>();
        }

        public int KategoriId { get; set; }

        public string KategoriAdi { get; set; }

        public bool AktifMi { get; set; }



        public int? UstKategoriId { get; set; }
        public virtual Kategori UstKategori { get; set; }

        public int? HaberId { get; set; }
        public virtual ICollection<Haber> Haberler { get; set; }

        public int? YazarId { get; set; }
        public virtual ICollection<Yazar> Yazarlar { get; set; }

    }
}
