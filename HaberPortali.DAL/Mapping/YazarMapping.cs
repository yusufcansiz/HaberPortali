using HaberPortali.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.DAL.Mapping
{
    public class YazarMapping : EntityTypeConfiguration<Yazar>
    {
        public YazarMapping()
        {
            HasKey(x => x.YazarId);
            Property(x => x.YazarAd).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.YazarSoyad).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            //Property(x => x.YorumId).IsRequired();
            //Property(x => x.KategoriId).IsRequired();
            //Property(x => x.HaberId).IsRequired();
            
        }
    }
}
