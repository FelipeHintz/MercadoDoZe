namespace Mercado_do_zé.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste1121 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Descricao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Descricao");
        }
    }
}
