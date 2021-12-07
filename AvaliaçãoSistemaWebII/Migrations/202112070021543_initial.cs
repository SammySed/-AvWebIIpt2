namespace AvaliaçãoSistemaWebII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedors",
                c => new
                    {
                        FornecedorId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        logradouro = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        cidade = c.String(),
                        ProdutoId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.FornecedorId)
                .ForeignKey("dbo.Produtoes", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ProdutoId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fornecedors", "ProdutoId", "dbo.Produtoes");
            DropIndex("dbo.Fornecedors", new[] { "ProdutoId" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.Fornecedors");
        }
    }
}
