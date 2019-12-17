using HaberPortali.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.DAL.Mapping
{
    public class KategoriMapping : EntityTypeConfiguration<Kategori>
    {
        public KategoriMapping()
        {
            HasKey(x => x.KategoriId);
            Property(x => x.KategoriAdi ).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            //Property(x => x.YazarId).IsRequired();
            //Property(x => x.HaberId).IsRequired();
            //Property(x => x.UstKategoriId).IsRequired();

            HasMany(x => x.Yazarlar).WithMany(y => y.Kategoriler).Map(m =>
            {
                m.ToTable("Kategori_Yazar");
                m.MapLeftKey("KategoriId");
                m.MapRightKey("YazarId");
            });
        }
    }
}
//HasMany(x=>x.Tags).WithMany(x=>x.Articles).Map(m =>
//            {
//    m.ToTable("Article_Tag");
//    m.MapLeftKey("ArticleId");
//    m.MapRightKey("TagId");
//});