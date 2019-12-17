using HaberPortali.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.DAL.Mapping
{
    public class YorumMapping : EntityTypeConfiguration<Yorum>
    {
        public YorumMapping()
        {
            HasKey(x => x.YorumId);
            Property(x => x.YorumAciklama).IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.YorumTarihi).IsOptional().HasColumnType("date");
            //Property(x => x.YazarID).IsRequired();
            //Property(x => x.HaberId).IsRequired();
            //Property(x => x.YorumId).IsRequired();

            HasRequired(x => x.Haber)
                .WithMany(h => h.Yorumlar)
                .HasForeignKey(x => x.HaberId);

            //HasRequired(x => x.Yazar)
            //    .WithMany(y => y.Yorumlar)
            //    .HasForeignKey(x => x.YazarID);
        }
    }
}
