namespace Biblioteca.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBBUS",
                c => new
                    {
                        Placa = c.String(nullable: false, maxLength: 128),
                        Tamaño = c.String(maxLength: 6),
                        Capacidad = c.String(),
                        Fecha = c.String(maxLength: 11),
                        Estado = c.String(name: "Estado ", maxLength: 3),
                        linea = c.String(maxLength: 8),
                    })
                .PrimaryKey(t => t.Placa);
            
            CreateTable(
                "dbo.TBEMPLEADO",
                c => new
                    {
                        codempleado = c.String(nullable: false, maxLength: 128),
                        claveemp = c.String(maxLength: 40),
                        nombreemp = c.String(maxLength: 40),
                        apellidosemp = c.String(maxLength: 100),
                        emailemp = c.String(maxLength: 9),
                        telefonoemp = c.String(),
                        cargoemp = c.String(maxLength: 10),
                        estadoemp = c.String(maxLength: 30),
                        nrolicencia = c.String(),
                        tipolicencia = c.String(),
                    })
                .PrimaryKey(t => t.codempleado);
            
            CreateTable(
                "dbo.TBLINIA",
                c => new
                    {
                        linea = c.String(nullable: false, maxLength: 128),
                        codempleado = c.String(maxLength: 40),
                        codbus = c.String(maxLength: 40),
                        codruta = c.String(maxLength: 100),
                        fecha = c.String(),
                    })
                .PrimaryKey(t => t.linea);
            
            CreateTable(
                "dbo.TBRUTA",
                c => new
                    {
                        codruta = c.Int(nullable: false, identity: true),
                        rutaltdlng = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.codruta);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TBRUTA");
            DropTable("dbo.TBLINIA");
            DropTable("dbo.TBEMPLEADO");
            DropTable("dbo.TBBUS");
        }
    }
}
