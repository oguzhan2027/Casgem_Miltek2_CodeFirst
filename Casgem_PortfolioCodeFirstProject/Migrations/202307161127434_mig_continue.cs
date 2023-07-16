namespace Casgem_PortfolioCodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_continue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        AboutDes = c.String(),
                        AboutTitle = c.String(),
                        AboutResim = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryURL = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        FeatureDes = c.String(),
                        FeatureTitle = c.String(),
                        FeatureImage = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryID = c.Int(nullable: false, identity: true),
                        GalleryURL = c.String(),
                    })
                .PrimaryKey(t => t.GalleryID);
            
            CreateTable(
                "dbo.Iletisims",
                c => new
                    {
                        IletisimID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Telefon = c.String(),
                        Mail = c.String(),
                        FaceURL = c.String(),
                        TwitterURL = c.String(),
                        InsagramURL = c.String(),
                        MailURL = c.String(),
                        LinkedinURL = c.String(),
                    })
                .PrimaryKey(t => t.IletisimID);
            
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        TravelID = c.Int(nullable: false, identity: true),
                        TravelCategory = c.String(),
                    })
                .PrimaryKey(t => t.TravelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Travels");
            DropTable("dbo.Iletisims");
            DropTable("dbo.Galleries");
            DropTable("dbo.Features");
            DropTable("dbo.Categories");
            DropTable("dbo.Abouts");
        }
    }
}
