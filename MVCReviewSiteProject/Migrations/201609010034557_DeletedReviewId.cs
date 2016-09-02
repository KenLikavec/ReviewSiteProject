namespace MVCReviewSiteProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedReviewId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reviews", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Id", c => c.String());
        }
    }
}
