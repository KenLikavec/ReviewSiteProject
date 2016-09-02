namespace MVCReviewSiteProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        recordNum = c.Int(nullable: false, identity: true),
                        Id = c.String(),
                        Title = c.String(),
                        Content = c.String(),
                        PublishDate = c.String(),
                    })
                .PrimaryKey(t => t.recordNum);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reviews");
        }
    }
}
