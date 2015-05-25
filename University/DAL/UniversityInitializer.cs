using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;
using System.Data.Entity;

namespace University.DAL
{
    public class UniversityInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            //base.Seed(context);
            //para agregar al inicio se utiliza la siguiente estructura
            //var students = new List<Student>
            //{
            //    new Student{Nombre="Carlos",Paterno="Estrada",Materno="Copa",Telefono=2269587,Celular=7957847,Email="carlos@gmail.com",Fecha_Inscripcion=DateTime.Parse("2014-05-06")},
            //    new Student{Nombre="Pedro",Paterno="Cooper",Materno="Oropeza",Telefono=2659877,Celular=7958746,Email="pedro@gmail.com",Fecha_Inscripcion=DateTime.Parse("2014-02-03")},
            //    new Student{Nombre="Ryan",Paterno="Lopez",Materno="Campero",Telefono=2354654,Celular=7236547,Email="ryan@gmail.com",Fecha_Inscripcion=DateTime.Parse("2014-08-14")},
            //    new Student{Nombre="Andres",Paterno="Tinta",Materno="Lima",Telefono=2987564,Celular=7569875,Email="andres@gmail.com",Fecha_Inscripcion=DateTime.Parse("2015-03-09")},
            //};
            //students.ForEach(s => context.Students.Add(s));
            //context.SaveChanges();//guarda los cambios
            //var catedraticos = new List<Catedratico>
            //{
            //    new Catedratico{Nombre="Roberto",Paterno="Oropeza",Profesion="Ingeniero",Carrera="Sistemas"},
            //    new Catedratico{Nombre="Gustavo",Paterno="Tirado",Profesion="Arquitecto",Carrera=""},
            //    new Catedratico{Nombre="Luis",Paterno="Arcani",Profesion="Ingeniero",Carrera="Sistemas"},
            //    new Catedratico{Nombre="Andres",Paterno="Quintanilla",Profesion="Ingeniero",Carrera="Sistemas"},
            //    new Catedratico{Nombre="Sonia",Paterno="Lima",Profesion="Arquitecto",Carrera="Arquitectura"},
            //};
            //catedraticos.ForEach(s => context.Catedraticos.Add(s));
            //context.SaveChanges();
            //var materias = new List<Materia>
            //{
            //    new Materia{CatedraticoId=1,Nombre="Java",Carga_Horaria=2,AulaId="A",Carrera="Sistemas",Nro_Creditos=3},
            //    new Materia{CatedraticoId=1,Nombre="Programacion avanzada",Carga_Horaria=3,AulaId="C",Carrera="Sistemas",Nro_Creditos=3},
            //    new Materia{CatedraticoId=2,Nombre="Diseño de interiores",Carga_Horaria=4,AulaId="Arquitectura",Carrera="",Nro_Creditos=3},
            //    new Materia{CatedraticoId=3,Nombre="Java",Carga_Horaria=2,AulaId="A",Carrera="Sistemas",Nro_Creditos=3},
            //    new Materia{CatedraticoId=4,Nombre="BDII",Carga_Horaria=2,AulaId="A",Carrera="Sistemas",Nro_Creditos=3},
            //    new Materia{CatedraticoId=4,Nombre="Linq",Carga_Horaria=2,AulaId="B",Carrera="Sistemas",Nro_Creditos=3},
            //};
            //materias.ForEach(s => context.Materias.Add(s));
            //context.SaveChanges();
            //var inscripciones = new List<Inscripcion>
            //{
            //    new Inscripcion{StudentId=1,MateriaId=1,Semestre=Semestre.primero},
            //    new Inscripcion{StudentId=2,MateriaId=2,Semestre=Semestre.segundo},
            //    new Inscripcion{StudentId=3,MateriaId=3,Semestre=Semestre.sexto},
            //    new Inscripcion{StudentId=4,MateriaId=4,Semestre=Semestre.septimo},
            //};
            //inscripciones.ForEach(s => context.Inscripciones.Add(s));
            //context.SaveChanges();
        }
    }
}
