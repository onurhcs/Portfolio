namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Photo", c => c.Binary());
        }
    }
}
