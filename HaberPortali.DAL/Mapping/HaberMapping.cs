using HaberPortali.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.DAL.Mapping
{
    public class HaberMapping : EntityTypeConfiguration<Haber>
    {
        public HaberMapping()
        {
            HasKey(x => x.HaberId);
            Property(x => x.HaberBaslik).HasColumnType("nvarchar").IsRequired().HasMaxLength(75);
            Property(x => x.HaberDetay).IsRequired().HasColumnType("text");
            Property(x => x.HaberOzet).IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.YayinlanmaTarihi).HasColumnType("date");
            //Property(x => x.YazarId).IsRequired();
            //Property(x => x.KategoriId).IsRequired();
            //Property(x => x.YorumId).IsRequired();
            //Property(x => x.HaberId).IsRequired();
            //Property(x => x.FotografId).IsRequired();

            HasMany(x => x.Kategoriler)
                .WithMany(k => k.Haberler)
                .Map(m =>
                            {
                                m.ToTable("Haber_Kategori");
                                m.MapLeftKey("HaberId");
                                m.MapRightKey("KategoriId");
                            });

            HasRequired(x => x.Yazar)
                .WithMany(y => y.Haberler)
                .HasForeignKey(x => x.YazarId);

        }
    }
}
