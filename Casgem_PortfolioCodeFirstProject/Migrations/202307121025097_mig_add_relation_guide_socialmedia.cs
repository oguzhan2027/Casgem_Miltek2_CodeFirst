namespace Casgem_PortfolioCodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_relation_guide_socialmedia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guides", "GuideImageURL", c => c.String());
            DropColumn("dbo.Guides", "ImageURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guides", "ImageURL", c => c.String());
            DropColumn("dbo.Guides", "GuideImageURL");
        }
    }
}
