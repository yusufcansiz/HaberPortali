using HaberPortali.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Entity.Model
{
    public class Fotograf : IEntity
    {
        public int FotografId { get; set; }

        public string FotografYolu { get; set; }


        //[ForeignKey("Haber")]
        public int? HaberId { get; set; }

        public virtual Haber Haber { get; set; }
    }
}
