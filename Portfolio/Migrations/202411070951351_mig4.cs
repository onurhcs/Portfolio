namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Photo");
        }
    }
}
