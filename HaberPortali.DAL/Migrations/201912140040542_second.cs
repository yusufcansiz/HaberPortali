namespace HaberPortali.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Yorums", "YazarId", "dbo.Yazars");
            DropIndex("dbo.Yorums", new[] { "YazarId" });
            AddColumn("dbo.Yazars", "Email", c => c.String());
            AddColumn("dbo.Yazars", "Sifre", c => c.String());
            DropColumn("dbo.Yazars", "YorumId");
            DropColumn("dbo.Yorums", "YazarId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yorums", "YazarId", c => c.Int(nullable: false));
            AddColumn("dbo.Yazars", "YorumId", c => c.Int(nullable: false));
            DropColumn("dbo.Yazars", "Sifre");
            DropColumn("dbo.Yazars", "Email");
            CreateIndex("dbo.Yorums", "YazarId");
            AddForeignKey("dbo.Yorums", "YazarId", "dbo.Yazars", "YazarId", cascadeDelete: true);
        }
    }
}
