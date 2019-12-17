using HaberPortali.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Entity.Model
{
    public class Yorum : IEntity
    {
        public int YorumId { get; set; }

        public string YorumAciklama { get; set; }

        public DateTime YorumTarihi { get; set; }



        public int? HaberId { get; set; }
        public virtual Haber Haber { get; set; }

        //public int YazarID { get; set; }
        //public virtual Yazar Yazar { get; set; }
    }
}
