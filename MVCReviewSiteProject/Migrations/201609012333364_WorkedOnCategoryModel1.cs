namespace MVCReviewSiteProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkedOnCategoryModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "PublishDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "PublishDate", c => c.String());
        }
    }
}
