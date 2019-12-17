namespace HaberPortali.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fotografs",
                c => new
                    {
                        FotografId = c.Int(nullable: false, identity: true),
                        FotografYolu = c.String(nullable: false, maxLength: 4000),
                        HaberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FotografId)
                .ForeignKey("dbo.Habers", t => t.HaberId, cascadeDelete: true)
                .Index(t => t.HaberId);
            
            CreateTable(
                "dbo.Habers",
                c => new
                    {
                        HaberId = c.Int(nullable: false, identity: true),
                        HaberBaslik = c.String(nullable: false, maxLength: 75),
                        HaberOzet = c.String(nullable: false, maxLength: 250),
                        HaberDetay = c.String(nullable: false, unicode: false, storeType: "text"),
                        YayinlanmaTarihi = c.DateTime(nullable: false, storeType: "date"),
                        AktifMi = c.Boolean(nullable: false),
                        PopulerMi = c.Boolean(nullable: false),
                        GoruntulenmeSayisi = c.Int(),
                        BegenmeSayisi = c.Int(),
                        YazarId = c.Int(nullable: false),
                        YorumId = c.Int(nullable: false),
                        FotografId = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HaberId)
                .ForeignKey("dbo.Yazars", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 50),
                        AktifMi = c.Boolean(nullable: false),
                        UstKategoriId = c.Int(nullable: false),
                        HaberId = c.Int(nullable: false),
                        YazarId = c.Int(nullable: false),
                        UstKategori_KategoriId = c.Int(),
                    })
                .PrimaryKey(t => t.KategoriId)
                .ForeignKey("dbo.Kategoris", t => t.UstKategori_KategoriId)
                .Index(t => t.UstKategori_KategoriId);
            
            CreateTable(
                "dbo.Yazars",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        YazarAd = c.String(nullable: false, maxLength: 50),
                        YazarSoyad = c.String(nullable: false, maxLength: 50),
                        AktifMi = c.Boolean(nullable: false),
                        Rolu = c.Int(nullable: false),
                        HaberId = c.Int(nullable: false),
                       // YorumId = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.YazarId);

            CreateTable(
                "dbo.Yorums",
                c => new
                {
                    YorumId = c.Int(nullable: false, identity: true),
                    YorumAciklama = c.String(nullable: false, maxLength: 250),
                    YorumTarihi = c.DateTime(storeType: "date"),
                    HaberId = c.Int(nullable: false),
                    //YazarId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.YorumId)
                .ForeignKey("dbo.Habers", t => t.HaberId, cascadeDelete: true)
                //.ForeignKey("dbo.Yazars", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.HaberId);
                //.Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Kategori_Yazar",
                c => new
                    {
                        KategoriId = c.Int(nullable: false),
                        YazarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.KategoriId, t.YazarId })
                .ForeignKey("dbo.Kategoris", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Yazars", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Haber_Kategori",
                c => new
                    {
                        HaberId = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HaberId, t.KategoriId })
                .ForeignKey("dbo.Habers", t => t.HaberId, cascadeDelete: true)
                .ForeignKey("dbo.Kategoris", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.HaberId)
                .Index(t => t.KategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fotografs", "HaberId", "dbo.Habers");
            DropForeignKey("dbo.Habers", "YazarId", "dbo.Yazars");
            DropForeignKey("dbo.Haber_Kategori", "KategoriId", "dbo.Kategoris");
            DropForeignKey("dbo.Haber_Kategori", "HaberId", "dbo.Habers");
            DropForeignKey("dbo.Kategori_Yazar", "YazarId", "dbo.Yazars");
            DropForeignKey("dbo.Kategori_Yazar", "KategoriId", "dbo.Kategoris");
            DropForeignKey("dbo.Yorums", "YazarId", "dbo.Yazars");
            DropForeignKey("dbo.Yorums", "HaberId", "dbo.Habers");
            DropForeignKey("dbo.Kategoris", "UstKategori_KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Haber_Kategori", new[] { "KategoriId" });
            DropIndex("dbo.Haber_Kategori", new[] { "HaberId" });
            DropIndex("dbo.Kategori_Yazar", new[] { "YazarId" });
            DropIndex("dbo.Kategori_Yazar", new[] { "KategoriId" });
            DropIndex("dbo.Yorums", new[] { "YazarId" });
            DropIndex("dbo.Yorums", new[] { "HaberId" });
            DropIndex("dbo.Kategoris", new[] { "UstKategori_KategoriId" });
            DropIndex("dbo.Habers", new[] { "YazarId" });
            DropIndex("dbo.Fotografs", new[] { "HaberId" });
            DropTable("dbo.Haber_Kategori");
            DropTable("dbo.Kategori_Yazar");
            DropTable("dbo.Yorums");
            DropTable("dbo.Yazars");
            DropTable("dbo.Kategoris");
            DropTable("dbo.Habers");
            DropTable("dbo.Fotografs");
        }
    }
}
