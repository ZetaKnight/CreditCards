namespace CreditCards.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false, storeType: "date"),
                        Income = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CardId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CreditCards", t => t.CardId)
                .Index(t => t.CardId);
            
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Apr = c.String(),
                        PromoMessage = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserApplications", "CardId", "dbo.CreditCards");
            DropIndex("dbo.UserApplications", new[] { "CardId" });
            DropTable("dbo.CreditCards");
            DropTable("dbo.UserApplications");
        }
    }
}
