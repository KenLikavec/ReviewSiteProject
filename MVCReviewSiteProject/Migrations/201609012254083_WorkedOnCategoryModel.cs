namespace MVCReviewSiteProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkedOnCategoryModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        recordNum = c.Int(nullable: false, identity: true),
                        Id = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.recordNum);
            
            AddColumn("dbo.Reviews", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "CategoryID");
            AddForeignKey("dbo.Reviews", "CategoryID", "dbo.Categories", "recordNum", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Reviews", new[] { "CategoryID" });
            DropColumn("dbo.Reviews", "CategoryID");
            DropTable("dbo.Categories");
        }
    }
}
