namespace Kintrests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTableNames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetUserClaims", newName: "UserClaim");
            RenameTable(name: "dbo.AspNetUserLogins", newName: "UserLogin");
            RenameTable(name: "dbo.AspNetUserRoles", newName: "UserRoles");
            RenameTable(name: "dbo.AspNetRoles", newName: "Role");
            AddColumn("dbo.Users", "Handle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Handle");
            RenameTable(name: "dbo.Role", newName: "AspNetRoles");
            RenameTable(name: "dbo.UserRoles", newName: "AspNetUserRoles");
            RenameTable(name: "dbo.UserLogin", newName: "AspNetUserLogins");
            RenameTable(name: "dbo.UserClaim", newName: "AspNetUserClaims");
        }
    }
}
