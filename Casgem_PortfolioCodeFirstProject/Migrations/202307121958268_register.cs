namespace Casgem_PortfolioCodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class register : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        RegisterID = c.Int(nullable: false, identity: true),
                        RegisterUserName = c.String(),
                        RegisterMail = c.String(),
                        RegisterContactNumber = c.String(),
                        RegisterPassword = c.String(),
                    })
                .PrimaryKey(t => t.RegisterID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registers");
        }
    }
}
