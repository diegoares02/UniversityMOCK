namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catedratico",
                c => new
                    {
                        CatedraticoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Paterno = c.String(),
                        Profesion = c.String(),
                        Carrera = c.String(),
                    })
                .PrimaryKey(t => t.CatedraticoId);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        MateriaId = c.Int(nullable: false, identity: true),
                        CatedraticoId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Carga_Horaria = c.Int(nullable: false),
                        AulaId = c.String(),
                        Carrera = c.String(),
                        Nro_Creditos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MateriaId)
                .ForeignKey("dbo.Catedratico", t => t.CatedraticoId, cascadeDelete: true)
                .Index(t => t.CatedraticoId);
            
            CreateTable(
                "dbo.Inscripcion",
                c => new
                    {
                        InscripcionId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        MateriaId = c.Int(nullable: false),
                        Semestre = c.Int(),
                    })
                .PrimaryKey(t => t.InscripcionId)
                .ForeignKey("dbo.Materia", t => t.MateriaId, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.MateriaId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Paterno = c.String(),
                        Materno = c.String(),
                        Telefono = c.Int(nullable: false),
                        Celular = c.Int(nullable: false),
                        Email = c.String(),
                        Fecha_Inscripcion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscripcion", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Inscripcion", "MateriaId", "dbo.Materia");
            DropForeignKey("dbo.Materia", "CatedraticoId", "dbo.Catedratico");
            DropIndex("dbo.Inscripcion", new[] { "MateriaId" });
            DropIndex("dbo.Inscripcion", new[] { "StudentId" });
            DropIndex("dbo.Materia", new[] { "CatedraticoId" });
            DropTable("dbo.Student");
            DropTable("dbo.Inscripcion");
            DropTable("dbo.Materia");
            DropTable("dbo.Catedratico");
        }
    }
}
