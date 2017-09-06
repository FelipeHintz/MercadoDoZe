namespace Mercado_do_zé.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFree = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clientes", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Clientes", "MembershipTypeId");
            AddForeignKey("dbo.Clientes", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Clientes", new[] { "MembershipTypeId" });
            DropColumn("dbo.Clientes", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
