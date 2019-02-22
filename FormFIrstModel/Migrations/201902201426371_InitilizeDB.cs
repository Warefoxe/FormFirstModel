namespace FormFIrstModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitilizeDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Course = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_Students");
        }
    }
}
