namespace StudentDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Marks", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Marks");
        }
    }
}
