namespace iChat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iChatContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messagers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        IdUser_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.IdUser_Id)
                .Index(t => t.IdUser_Id);
            
            AddColumn("dbo.Users", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messagers", "IdUser_Id", "dbo.Users");
            DropIndex("dbo.Messagers", new[] { "IdUser_Id" });
            DropColumn("dbo.Users", "Status");
            DropTable("dbo.Messagers");
        }
    }
}
