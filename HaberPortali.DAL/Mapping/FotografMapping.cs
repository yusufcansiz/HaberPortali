using HaberPortali.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.DAL.Mapping
{
    public class FotografMapping : EntityTypeConfiguration<Fotograf>
    {
        public FotografMapping()
        {
            HasKey(x => x.FotografId);
            Property(x => x.FotografYolu).HasColumnType("nvarchar").IsRequired();
            //Property(x => x.HaberId).IsRequired();
            
            HasRequired(f => f.Haber)
                .WithMany(h => h.Fotograf)
                .HasForeignKey(f => f.HaberId);

            //    .HasRequired<Grade>(s => s.CurrentGrade)
            //    .WithMany(g => g.Students)
            //    .HasForeignKey<int>(s => s.CurrentGradeId);
            //}

        }
    }
}
//HasMany(x=>x.Tags).WithMany(x=>x.Articles).Map(m =>
//            {
//    m.ToTable("Article_Tag");
//    m.MapLeftKey("ArticleId");
//    m.MapRightKey("TagId");
//});