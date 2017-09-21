namespace EtiquetaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacao_Banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_Etiqueta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataFabricao = c.DateTime(),
                        DataValidade = c.DateTime(),
                        QuantidadePorcao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnidadeMedida = c.String(maxLength: 10),
                        DataCadastro = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_Produto", t => t.Produto_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.TB_Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 200),
                        PrecoVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ingrediente = c.String(maxLength: 500),
                        DataCadastro = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_InformacaoNutricional",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 50),
                        UnidadeMedia = c.String(maxLength: 10),
                        Quantidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorDiario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataCadastro = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                        ProdutoModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_Produto", t => t.ProdutoModel_Id)
                .Index(t => t.ProdutoModel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_Etiqueta", "Produto_Id", "dbo.TB_Produto");
            DropForeignKey("dbo.TB_InformacaoNutricional", "ProdutoModel_Id", "dbo.TB_Produto");
            DropIndex("dbo.TB_InformacaoNutricional", new[] { "ProdutoModel_Id" });
            DropIndex("dbo.TB_Etiqueta", new[] { "Produto_Id" });
            DropTable("dbo.TB_InformacaoNutricional");
            DropTable("dbo.TB_Produto");
            DropTable("dbo.TB_Etiqueta");
        }
    }
}
