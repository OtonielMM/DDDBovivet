namespace DDDBovivet.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Brinco = c.String(),
                        Nome = c.String(),
                        Raca = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdeOnHand = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exames",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Numero = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Veterinario_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Veterinario", t => t.Veterinario_Id)
                .Index(t => t.Veterinario_Id);
            
            CreateTable(
                "dbo.Veterinario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome_Nome1 = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        Nome_Sobrenome = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        Documento = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        Email_EndEmail = c.String(),
                        Fone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exames", "Veterinario_Id", "dbo.Veterinario");
            DropIndex("dbo.Exames", new[] { "Veterinario_Id" });
            DropTable("dbo.Veterinario");
            DropTable("dbo.Exames");
            DropTable("dbo.Animals");
        }
    }
}
