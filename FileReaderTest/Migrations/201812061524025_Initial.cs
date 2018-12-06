namespace FileReaderTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sobrenome = c.String(),
                        DataNasc = c.DateTime(nullable: false),
                        Sexo = c.String(),
                        Email = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.ProdutoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produto");
            DropTable("dbo.Cliente");
        }
    }
}
