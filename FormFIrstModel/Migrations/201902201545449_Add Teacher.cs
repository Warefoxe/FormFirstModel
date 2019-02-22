namespace FormFIrstModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Teacher",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DateStartWork = c.DateTime(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.tbl_Group", "KuratorID");
            AddForeignKey("dbo.tbl_Group", "KuratorID", "dbo.tbl_Teacher", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_Group", "KuratorID", "dbo.tbl_Teacher");
            DropIndex("dbo.tbl_Group", new[] { "KuratorID" });
            DropTable("dbo.tbl_Teacher");
        }
    }
}
