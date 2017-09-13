namespace Mercado_do_zé.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "EnderecoImagem", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "EnderecoImagem");
        }
    }
}
