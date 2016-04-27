namespace Kintrests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class takeRequirementOff : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kins", "Owner_Id", "dbo.Users");
            DropIndex("dbo.Kins", new[] { "Owner_Id" });
            AlterColumn("dbo.Kins", "Owner_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Kins", "Owner_Id");
            AddForeignKey("dbo.Kins", "Owner_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kins", "Owner_Id", "dbo.Users");
            DropIndex("dbo.Kins", new[] { "Owner_Id" });
            AlterColumn("dbo.Kins", "Owner_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Kins", "Owner_Id");
            AddForeignKey("dbo.Kins", "Owner_Id", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
