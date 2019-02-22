namespace FormFIrstModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForegeinKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Students", "GroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.tbl_Students", "GroupId");
            AddForeignKey("dbo.tbl_Students", "GroupId", "dbo.tbl_Group", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_Students", "GroupId", "dbo.tbl_Group");
            DropIndex("dbo.tbl_Students", new[] { "GroupId" });
            DropColumn("dbo.tbl_Students", "GroupId");
        }
    }
}
