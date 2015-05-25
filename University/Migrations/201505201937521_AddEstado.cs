namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEstado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Nota", "Estado", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Nota", "Estado");
        }
    }
}
