using HaberPortali.DAL.Mapping;
using HaberPortali.Entity.Model;
using System.Data.Entity;

namespace HaberPortali.DAL
{
    public class HaberContext : DbContext
    {
        public HaberContext() : base(ConnectionString.ConnectionStr)
        {
            var id = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Fotograf> Fotograflar { get; set; }

        public DbSet<Haber> Haberler { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Yazar> Yazarlar { get; set; }

        public DbSet<Yorum> Yorumlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KategoriMapping());
            modelBuilder.Configurations.Add(new FotografMapping());
            modelBuilder.Configurations.Add(new HaberMapping());
            modelBuilder.Configurations.Add(new YorumMapping());
            modelBuilder.Configurations.Add(new YazarMapping());

            base.OnModelCreating(modelBuilder);
        }



    }
}
