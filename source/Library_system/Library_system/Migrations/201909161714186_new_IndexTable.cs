namespace Library_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_IndexTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Index",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        RangeFrom = c.Int(nullable: false),
                        RangeTo = c.Int(nullable: false),
                        CurrentIndex = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Code);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Index");
        }
    }
}
