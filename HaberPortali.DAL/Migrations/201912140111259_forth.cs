namespace HaberPortali.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Habers", "YorumId", c => c.Int());
            AlterColumn("dbo.Habers", "FotografId", c => c.Int());
            AlterColumn("dbo.Habers", "KategoriId", c => c.Int());
            AlterColumn("dbo.Kategoris", "UstKategoriId", c => c.Int());
            AlterColumn("dbo.Kategoris", "HaberId", c => c.Int());
            AlterColumn("dbo.Kategoris", "YazarId", c => c.Int());
            AlterColumn("dbo.Yazars", "HaberId", c => c.Int());
            AlterColumn("dbo.Yazars", "KategoriId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yazars", "KategoriId", c => c.Int(nullable: false));
            AlterColumn("dbo.Yazars", "HaberId", c => c.Int(nullable: false));
            AlterColumn("dbo.Kategoris", "YazarId", c => c.Int(nullable: false));
            AlterColumn("dbo.Kategoris", "HaberId", c => c.Int(nullable: false));
            AlterColumn("dbo.Kategoris", "UstKategoriId", c => c.Int(nullable: false));
            AlterColumn("dbo.Habers", "KategoriId", c => c.Int(nullable: false));
            AlterColumn("dbo.Habers", "FotografId", c => c.Int(nullable: false));
            AlterColumn("dbo.Habers", "YorumId", c => c.Int(nullable: false));
        }
    }
}
