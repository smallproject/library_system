namespace Library_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_UserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Password = c.String(),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Account", "FirstName", c => c.String());
            AddColumn("dbo.Account", "LastName", c => c.String());
            AddColumn("dbo.Account", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Account", "Gender", c => c.String());
            AddColumn("dbo.Account", "MobileNumber", c => c.String());
            AddColumn("dbo.Account", "Email", c => c.String());
            DropColumn("dbo.Account", "User");
            DropColumn("dbo.Account", "Password");
            DropColumn("dbo.Account", "Created");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Account", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Account", "Password", c => c.String());
            AddColumn("dbo.Account", "User", c => c.String());
            DropColumn("dbo.Account", "Email");
            DropColumn("dbo.Account", "MobileNumber");
            DropColumn("dbo.Account", "Gender");
            DropColumn("dbo.Account", "BirthDate");
            DropColumn("dbo.Account", "LastName");
            DropColumn("dbo.Account", "FirstName");
            DropTable("dbo.User");
        }
    }
}
