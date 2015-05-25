namespace University.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using University.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<University.DAL.UniversityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "University.DAL.UniversityContext";
        }

        protected override void Seed(University.DAL.UniversityContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //            
            var carreras = new List<Carrera>
            {
                new Carrera{Nombre="Ingenieria Electronica",NroMaterias=24},
                new Carrera{Nombre="Ingenieria Sistemas",NroMaterias=24},
            };
            carreras.ForEach(s => context.Carreras.AddOrUpdate(s));
            context.SaveChanges();
            var cursos = new List<Curso>
            {
                new Curso{Semestre="Primer",MateriaId=1,CatedraticoId=1,Horario="L - Mi - V 8:00 - 10:00",Aula="A-301"},
                new Curso{Semestre="Segundo",MateriaId=2,CatedraticoId=2,Horario="L - Mi - V 10:00 - 12:00",Aula="A-301"},
                new Curso{Semestre="Primer",MateriaId=3,CatedraticoId=3,Horario="L - M - J 10:00 - 12:00",Aula="A-302"},
                new Curso{Semestre="Primer",MateriaId=4,CatedraticoId=4,Horario="L - Mi - V 8:00 - 10:00",Aula="A-302"},
                new Curso{Semestre="Segundo",MateriaId=5,CatedraticoId=5,Horario="L - Mi - V 8:00 - 10:00",Aula="A-303"},
                new Curso{Semestre="Primer",MateriaId=6,CatedraticoId=3,Horario="L - Mi - V 8:00 - 10:00",Aula="A-303"},
                new Curso{Semestre="Segundo",MateriaId=7,CatedraticoId=1,Horario="L - Mi - V 14:00 - 16:00",Aula="A-304"},
                new Curso{Semestre="Primer",MateriaId=25,CatedraticoId=2,Horario="L - Mi - V 8:00 - 10:00",Aula="A-304"},
                new Curso{Semestre="Primer",MateriaId=26,CatedraticoId=3,Horario="L - Mi - V 14:00 - 16:00",Aula="A-305"},
                new Curso{Semestre="Primer",MateriaId=27,CatedraticoId=4,Horario="L - Mi - V 16:00 - 18:00",Aula="A-305"},
                new Curso{Semestre="Primer",MateriaId=28,CatedraticoId=5,Horario="L - Mi - V 18:00 - 20:00",Aula="A-306"},
                new Curso{Semestre="Primer",MateriaId=29,CatedraticoId=5,Horario="L - Mi - V 18:00 - 20:00",Aula="A-306"},
                new Curso{Semestre="Primer",MateriaId=30,CatedraticoId=5,Horario="L - Mi - V 18:00 - 20:00",Aula="A-306"},
                new Curso{Semestre="Primer",MateriaId=31,CatedraticoId=5,Horario="L - Mi - V 18:00 - 20:00",Aula="A-306"},
            };
            cursos.ForEach(s => context.Cursos.AddOrUpdate(s));
            context.SaveChanges();
            var inscripciones = new List<Inscripcion>
            {
                new Inscripcion{StudentId=1,CursoId=1,Fecha_Inscripcion=DateTime.Parse("2014-05-06")},
                new Inscripcion{StudentId=1,CursoId=2,Fecha_Inscripcion=DateTime.Parse("2014-05-06")},
                new Inscripcion{StudentId=1,CursoId=3,Fecha_Inscripcion=DateTime.Parse("2014-05-06")},
                new Inscripcion{StudentId=1,CursoId=4,Fecha_Inscripcion=DateTime.Parse("2014-05-06")},
                new Inscripcion{StudentId=1,CursoId=5,Fecha_Inscripcion=DateTime.Parse("2014-05-07")},
                new Inscripcion{StudentId=1,CursoId=6,Fecha_Inscripcion=DateTime.Parse("2014-05-07")},
                new Inscripcion{StudentId=2,CursoId=1,Fecha_Inscripcion=DateTime.Parse("2014-05-07")},
                new Inscripcion{StudentId=2,CursoId=2,Fecha_Inscripcion=DateTime.Parse("2014-05-07")},
                new Inscripcion{StudentId=2,CursoId=3,Fecha_Inscripcion=DateTime.Parse("2014-05-08")},
                new Inscripcion{StudentId=2,CursoId=4,Fecha_Inscripcion=DateTime.Parse("2014-05-08")},
                new Inscripcion{StudentId=2,CursoId=5,Fecha_Inscripcion=DateTime.Parse("2014-05-08")},
                new Inscripcion{StudentId=2,CursoId=6,Fecha_Inscripcion=DateTime.Parse("2014-05-08")},
                new Inscripcion{StudentId=3,CursoId=1,Fecha_Inscripcion=DateTime.Parse("2014-05-09")},
                new Inscripcion{StudentId=3,CursoId=2,Fecha_Inscripcion=DateTime.Parse("2014-05-09")},
                new Inscripcion{StudentId=3,CursoId=3,Fecha_Inscripcion=DateTime.Parse("2014-05-09")},
                new Inscripcion{StudentId=3,CursoId=4,Fecha_Inscripcion=DateTime.Parse("2014-05-09")},
                new Inscripcion{StudentId=3,CursoId=5,Fecha_Inscripcion=DateTime.Parse("2014-05-09")},
                new Inscripcion{StudentId=3,CursoId=6,Fecha_Inscripcion=DateTime.Parse("2014-05-10")},
                new Inscripcion{StudentId=4,CursoId=8,Fecha_Inscripcion=DateTime.Parse("2014-05-10")},
                new Inscripcion{StudentId=4,CursoId=9,Fecha_Inscripcion=DateTime.Parse("2014-05-10")},
                new Inscripcion{StudentId=4,CursoId=10,Fecha_Inscripcion=DateTime.Parse("2014-05-10")},
                new Inscripcion{StudentId=4,CursoId=11,Fecha_Inscripcion=DateTime.Parse("2014-05-10")},
                new Inscripcion{StudentId=4,CursoId=12,Fecha_Inscripcion=DateTime.Parse("2014-05-10")},
                new Inscripcion{StudentId=4,CursoId=13,Fecha_Inscripcion=DateTime.Parse("2014-05-10")},
                new Inscripcion{StudentId=4,CursoId=14,Fecha_Inscripcion=DateTime.Parse("2014-05-10")},
            };
            inscripciones.ForEach(s => context.Inscripciones.AddOrUpdate(s));
            context.SaveChanges();
            var notas = new List<Nota>
            {
                new Nota{ PrimerParcial=50,SegundoParcial=20,TercerParcial=80,CuartoParcial=60,NotaFinal=(50+20+80+60)/4,InscripcionId=1},
                new Nota{ PrimerParcial=60,SegundoParcial=30,TercerParcial=80,CuartoParcial=60,NotaFinal=(60+30+80+60)/4,InscripcionId=2},
                new Nota{ PrimerParcial=70,SegundoParcial=40,TercerParcial=60,CuartoParcial=60,NotaFinal=(70+40+60+60)/4,InscripcionId=3},
                new Nota{ PrimerParcial=80,SegundoParcial=50,TercerParcial=20,CuartoParcial=60,NotaFinal=(80+50+20+60)/4,InscripcionId=4},
                new Nota{ PrimerParcial=50,SegundoParcial=60,TercerParcial=10,CuartoParcial=50,NotaFinal=(50+60+10+50)/4,InscripcionId=5},
                new Nota{ PrimerParcial=60,SegundoParcial=70,TercerParcial=20,CuartoParcial=40,NotaFinal=(60+70+20+40)/4,InscripcionId=6},
                new Nota{ PrimerParcial=55,SegundoParcial=80,TercerParcial=10,CuartoParcial=10,NotaFinal=(55+80+10+10)/4,InscripcionId=7},
                new Nota{ PrimerParcial=55,SegundoParcial=90,TercerParcial=30,CuartoParcial=65,NotaFinal=(55+90+30+65)/4,InscripcionId=8},
                new Nota{ PrimerParcial=54,SegundoParcial=100,TercerParcial=80,CuartoParcial=66,NotaFinal=(54+100+80+66)/4,InscripcionId=9},
                new Nota{ PrimerParcial=51,SegundoParcial=30,TercerParcial=80,CuartoParcial=70,NotaFinal=(51+30+80+70)/4,InscripcionId=10},
                new Nota{ PrimerParcial=50,SegundoParcial=10,TercerParcial=80,CuartoParcial=60,NotaFinal=(50+10+80+60)/4,InscripcionId=11},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=12},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=13},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=14},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=15},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=16},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=17},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=18},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=19},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=20},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=21},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=22},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=23},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=24},
                new Nota{ PrimerParcial=57,SegundoParcial=20,TercerParcial=80,CuartoParcial=68,NotaFinal=(57+20+80+68)/4,InscripcionId=25},
            };
            notas.ForEach(s => context.Notas.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
