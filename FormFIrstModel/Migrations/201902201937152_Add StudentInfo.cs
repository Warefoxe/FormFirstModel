namespace FormFIrstModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_StudentInfo",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbl_Students", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.tbl_Students", "StudentInfo_Id", c => c.Int());
            AddColumn("dbo.tbl_Students", "StudentInfo_Id1", c => c.Int());
            CreateIndex("dbo.tbl_Students", "StudentInfo_Id");
            CreateIndex("dbo.tbl_Students", "StudentInfo_Id1");
            AddForeignKey("dbo.tbl_Students", "StudentInfo_Id", "dbo.tbl_StudentInfo", "Id");
            AddForeignKey("dbo.tbl_Students", "StudentInfo_Id1", "dbo.tbl_StudentInfo", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_Students", "StudentInfo_Id1", "dbo.tbl_StudentInfo");
            DropForeignKey("dbo.tbl_StudentInfo", "Id", "dbo.tbl_Students");
            DropForeignKey("dbo.tbl_Students", "StudentInfo_Id", "dbo.tbl_StudentInfo");
            DropIndex("dbo.tbl_StudentInfo", new[] { "Id" });
            DropIndex("dbo.tbl_Students", new[] { "StudentInfo_Id1" });
            DropIndex("dbo.tbl_Students", new[] { "StudentInfo_Id" });
            DropColumn("dbo.tbl_Students", "StudentInfo_Id1");
            DropColumn("dbo.tbl_Students", "StudentInfo_Id");
            DropTable("dbo.tbl_StudentInfo");
        }
    }
}
