namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Materia", "CatedraticoId", "dbo.Catedratico");
            DropForeignKey("dbo.Inscripcion", "MateriaId", "dbo.Materia");
            DropForeignKey("dbo.Inscripcion", "StudentId", "dbo.Student");
            DropIndex("dbo.Materia", new[] { "CatedraticoId" });
            DropIndex("dbo.Inscripcion", new[] { "StudentId" });
            DropIndex("dbo.Inscripcion", new[] { "MateriaId" });
            CreateTable(
                "dbo.Carrera",
                c => new
                    {
                        CarreraId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        NroMaterias = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarreraId);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Semestre = c.String(),
                        MateriaId = c.Int(),
                        CatedraticoId = c.Int(),
                        Horario = c.String(),
                        Aula = c.String(),
                    })
                .PrimaryKey(t => t.CursoId)
                .ForeignKey("dbo.Catedratico", t => t.CatedraticoId)
                .ForeignKey("dbo.Materia", t => t.MateriaId)
                .Index(t => t.MateriaId)
                .Index(t => t.CatedraticoId);
            
            CreateTable(
                "dbo.Nota",
                c => new
                    {
                        NotaId = c.Int(nullable: false, identity: true),
                        PrimerParcial = c.Int(nullable: false),
                        SegundoParcial = c.Int(nullable: false),
                        TercerParcial = c.Int(nullable: false),
                        CuartoParcial = c.Int(nullable: false),
                        NotaFinal = c.Int(nullable: false),
                        InscripcionId = c.Int(),
                    })
                .PrimaryKey(t => t.NotaId)
                .ForeignKey("dbo.Inscripcion", t => t.InscripcionId)
                .Index(t => t.InscripcionId);
            
            AddColumn("dbo.Materia", "CarreraId", c => c.Int());
            AddColumn("dbo.Inscripcion", "CursoId", c => c.Int());
            AddColumn("dbo.Inscripcion", "Fecha_Inscripcion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Inscripcion", "StudentId", c => c.Int());
            CreateIndex("dbo.Materia", "CarreraId");
            CreateIndex("dbo.Inscripcion", "StudentId");
            CreateIndex("dbo.Inscripcion", "CursoId");
            AddForeignKey("dbo.Materia", "CarreraId", "dbo.Carrera", "CarreraId");
            AddForeignKey("dbo.Inscripcion", "CursoId", "dbo.Curso", "CursoId");
            AddForeignKey("dbo.Inscripcion", "StudentId", "dbo.Student", "StudentId");
            DropColumn("dbo.Catedratico", "Profesion");
            DropColumn("dbo.Catedratico", "Carrera");
            DropColumn("dbo.Materia", "CatedraticoId");
            DropColumn("dbo.Materia", "Carga_Horaria");
            DropColumn("dbo.Materia", "AulaId");
            DropColumn("dbo.Materia", "Carrera");
            DropColumn("dbo.Inscripcion", "MateriaId");
            DropColumn("dbo.Inscripcion", "Semestre");
            DropColumn("dbo.Student", "Celular");
            DropColumn("dbo.Student", "Email");
            DropColumn("dbo.Student", "Fecha_Inscripcion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "Fecha_Inscripcion", c => c.DateTime(nullable: false));
            AddColumn("dbo.Student", "Email", c => c.String());
            AddColumn("dbo.Student", "Celular", c => c.Int(nullable: false));
            AddColumn("dbo.Inscripcion", "Semestre", c => c.Int());
            AddColumn("dbo.Inscripcion", "MateriaId", c => c.Int(nullable: false));
            AddColumn("dbo.Materia", "Carrera", c => c.String());
            AddColumn("dbo.Materia", "AulaId", c => c.String());
            AddColumn("dbo.Materia", "Carga_Horaria", c => c.Int(nullable: false));
            AddColumn("dbo.Materia", "CatedraticoId", c => c.Int(nullable: false));
            AddColumn("dbo.Catedratico", "Carrera", c => c.String());
            AddColumn("dbo.Catedratico", "Profesion", c => c.String());
            DropForeignKey("dbo.Inscripcion", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Curso", "MateriaId", "dbo.Materia");
            DropForeignKey("dbo.Nota", "InscripcionId", "dbo.Inscripcion");
            DropForeignKey("dbo.Inscripcion", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Curso", "CatedraticoId", "dbo.Catedratico");
            DropForeignKey("dbo.Materia", "CarreraId", "dbo.Carrera");
            DropIndex("dbo.Nota", new[] { "InscripcionId" });
            DropIndex("dbo.Inscripcion", new[] { "CursoId" });
            DropIndex("dbo.Inscripcion", new[] { "StudentId" });
            DropIndex("dbo.Curso", new[] { "CatedraticoId" });
            DropIndex("dbo.Curso", new[] { "MateriaId" });
            DropIndex("dbo.Materia", new[] { "CarreraId" });
            AlterColumn("dbo.Inscripcion", "StudentId", c => c.Int(nullable: false));
            DropColumn("dbo.Inscripcion", "Fecha_Inscripcion");
            DropColumn("dbo.Inscripcion", "CursoId");
            DropColumn("dbo.Materia", "CarreraId");
            DropTable("dbo.Nota");
            DropTable("dbo.Curso");
            DropTable("dbo.Carrera");
            CreateIndex("dbo.Inscripcion", "MateriaId");
            CreateIndex("dbo.Inscripcion", "StudentId");
            CreateIndex("dbo.Materia", "CatedraticoId");
            AddForeignKey("dbo.Inscripcion", "StudentId", "dbo.Student", "StudentId", cascadeDelete: true);
            AddForeignKey("dbo.Inscripcion", "MateriaId", "dbo.Materia", "MateriaId", cascadeDelete: true);
            AddForeignKey("dbo.Materia", "CatedraticoId", "dbo.Catedratico", "CatedraticoId", cascadeDelete: true);
        }
    }
}
