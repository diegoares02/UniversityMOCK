using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University
{
    public class Program
    {
        public enum Operaciones { CREATE,UPDATE,DELETE,READ,EXIT}
        #region Metodos
        static Object LeerDatos(Object t)
        {
            Console.WriteLine("Ingrese los valores");
            BindingFlags flags = BindingFlags.Instance
            | BindingFlags.Public;
            PropertyInfo[] pr = t.GetType().GetProperties(flags);
            foreach (PropertyInfo m in pr)
            {
                if (!(m.PropertyType.IsSecurityCritical || m.PropertyType.IsConstructedGenericType))
                {
                    Console.Write(m.Name + " ");
                    var result = Console.ReadLine();
                    m.SetValue(t, Convert.ChangeType(result, m.PropertyType));
                }
            }
            return t;
        }
        static void MostrarDatos(Object o)
        {
            BindingFlags flags = BindingFlags.Instance
            | BindingFlags.Public;
            var elementype = o.GetType();
            var propertyinfo = elementype.GetProperties(flags);
            foreach (var item in propertyinfo)
            {
                if (!(item.PropertyType.IsSecurityCritical || item.PropertyType.IsConstructedGenericType))
                {
                Console.WriteLine(item.Name.ToString()+": " + item.GetValue(o));
                }
            }
        }
        static void Agregar(Object t)
        {
            using (var db = new DAL.UniversityContext())
            { 
                switch(t.GetType().Name)
                {
                    case "Student":
                        {
                            var result = LeerDatos(t); db.Students.Add((Student)result); db.SaveChanges(); Console.WriteLine("guardado con exito"); break;
                        }
                    case "Inscripcion":
                        {
                            var result = LeerDatos(t); db.Inscripciones.Add((Inscripcion)result); db.SaveChanges(); Console.WriteLine("guardado con exito"); break;
                        }
                    case "Materia":
                        {
                            var result = LeerDatos(t); db.Materias.Add((Materia)result); db.SaveChanges(); Console.WriteLine("guardado con exito"); break;
                        }
                    case "Catedratico":
                        {
                            var result = LeerDatos(t); db.Catedraticos.Add((Catedratico)result); db.SaveChanges(); Console.WriteLine("guardado con exito"); break;
                        }
                }
            }
        }

        #endregion
        static void Main(string[] args)
        {
            int op=0;
            do
            {
                Console.Clear();
                Console.WriteLine("HOMEWORK");
                Console.WriteLine("1. ESTUDIANTE");
                Console.WriteLine("2. INSCRIPCION");
                Console.WriteLine("3. MATERIA");
                Console.WriteLine("4. CATEDRATICO");
                Console.WriteLine("5. RECORD");
                Console.WriteLine("6. MATERIAS RESTANTES");
                Console.WriteLine("7. LISTA POR CURSO Y MATERIA");
                Console.WriteLine("8. LISTA CATEDRATICOS");
                Console.WriteLine("9. SALIR");
                Console.WriteLine("Ingrese una opcion");
                op=Convert.ToInt32(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        {
                            #region Estudiantes
                            int op1=0;
                            Student st = new Student();
                            do
                            {
                                int cont = 1;
                                Console.Clear();
                                foreach (var item in Enum.GetValues(typeof(Operaciones)))
                                {
                                    Console.WriteLine(cont.ToString()+". " + item);
                                    cont++;
                                }
                                op1 = Convert.ToInt32(Console.ReadLine());
                                switch(op1)
                                {
                                    case 1:
                                        {
                                            Agregar(st);
                                            break;
                                        }
                                    case 2:
                                        {//actualizar
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                Console.WriteLine("Ingrese nombre:");
                                                var nombre = Console.ReadLine();
                                                Student stu = db.Students.Where(s => s.Nombre == nombre).Single<Student>();
                                                Console.WriteLine("Ingrese Telefono:");
                                                stu.Telefono = Convert.ToInt32(Console.ReadLine()); 
                                                db.SaveChanges();
                                            }
                                            break; }
                                    case 3:
                                        {//eliminar
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                Console.WriteLine("Ingrese nombre:");
                                                var nombre = Console.ReadLine();
                                                var result = (from b in db.Students
                                                              where b.Nombre == nombre
                                                              select b).First();
                                                db.Students.Remove(result);
                                                db.SaveChanges();
                                            }
                                            break; }
                                    case 4:
                                        { //leer
                                            using(var db = new DAL.UniversityContext())
                                            {
                                                var query = from b in db.Students
                                                            select b;
                                                foreach (var aux in query)
                                                {                                                    
                                                    Console.WriteLine(aux.StudentId.ToString() + " " + aux.Nombre + " " + aux.Paterno + " " + aux.Materno + " " + aux.Telefono.ToString() + " ");
                                                }
                                            }
                                            break; 
                                        }
                                }
                                Console.ReadKey();
                            }
                            while (op1 < 5);
                            break;
                            #endregion
                        }
                    case 2:
                        {
                            #region Inscripciones
                            int op1 = 0; Inscripcion ins = new Inscripcion();
                            do
                            {
                                int cont = 1;
                                Console.Clear();
                                foreach (var item in Enum.GetValues(typeof(Operaciones)))
                                {
                                    Console.WriteLine(cont.ToString() + ". " + item);
                                    cont++;
                                }
                                op1 = Convert.ToInt32(Console.ReadLine());
                                switch (op1)
                                {
                                    case 1:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                Agregar(ins);
                                            }
                                            break; }
                                    case 2:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                Console.WriteLine("Ingrese Cod Student:");
                                                var cod = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Ingrese Cod Materia:");
                                                var materia = Convert.ToInt32(Console.ReadLine());
                                                Inscripcion st = db.Inscripciones.Where(s => s.StudentId == cod).Single<Inscripcion>();
                                                //st.MateriaId = materia;
                                                db.SaveChanges();
                                            }
                                            break; }
                                    case 3:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                Console.WriteLine("Ingrese cod student:");
                                                var nombre = Convert.ToInt32( Console.ReadLine());
                                                var result = (from b in db.Inscripciones
                                                              where b.StudentId == nombre
                                                              select b).First();
                                                db.Inscripciones.Remove(result);
                                                db.SaveChanges();
                                            }
                                            break; }
                                    case 4:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                var query = from b in db.Inscripciones
                                                            select b;
                                                foreach (var aux in query)
                                                {
                                                    //Console.WriteLine(aux.InscripcionId.ToString() + " " + aux.StudentId.ToString() + " " + aux.MateriaId.ToString() + " "+aux.Semestre.ToString());
                                                }
                                            }
                                            break; 
                                        }
                                }
                                Console.ReadKey();
                            }                            
                            
                            while (op1 < 5);
                            break;
                            #endregion
                        }
                    case 3:
                        {
                            #region Materias
                            int op1 = 0; Materia mat = new Materia();
                            do
                            {
                                int cont = 1;
                                Console.Clear();
                                foreach (var item in Enum.GetValues(typeof(Operaciones)))
                                {
                                    Console.WriteLine(cont.ToString() + ". " + item);
                                    cont++;
                                }
                                op1 = Convert.ToInt32(Console.ReadLine());
                                switch (op1)
                                {
                                    case 1:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                Agregar(mat);
                                            }
                                            break; }
                                    case 2:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                Console.WriteLine("Ingrese nombre de la materia:");
                                                var nombre = Console.ReadLine();
                                                Console.WriteLine("Ingrese Nro de creditos:");
                                                var carga = Convert.ToInt32(Console.ReadLine());
                                                Materia st = db.Materias.Where(s => s.Nombre == nombre).Single<Materia>();
                                                st.Nro_Creditos = carga;
                                                db.SaveChanges();
                                            }
                                            break; }
                                    case 3:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                Console.WriteLine("Ingrese Nombre de la materia:");
                                                var nombre = Console.ReadLine();
                                                var result = (from b in db.Materias
                                                              where b.Nombre == nombre
                                                              select b).First();
                                                db.Materias.Remove(result);
                                                db.SaveChanges();
                                            }
                                            break; }
                                    case 4:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                var query = from b in db.Materias
                                                            select b;
                                                foreach (var aux in query)
                                                {
                                                    Console.WriteLine(aux.MateriaId.ToString() + " " + aux.Nombre + " " +aux.Nro_Creditos.ToString());
                                                }
                                            }
                                            break; 
                                        }
                                }
                                Console.ReadKey();
                            }
                            while (op1 < 5);
                            break;
                            #endregion
                        }
                    case 4:
                        {
                            #region Catedraticos
                            int op1 = 0; Catedratico cat = new Catedratico();
                            do
                            {
                                int cont = 1;
                                Console.Clear();
                                foreach (var item in Enum.GetValues(typeof(Operaciones)))
                                {
                                    Console.WriteLine(cont.ToString() + ". " + item);
                                    cont++;
                                }
                                op1 = Convert.ToInt32(Console.ReadLine());
                                switch (op1)
                                {
                                    case 1:
                                        {
                                            Agregar(cat);
                                            break;
                                        }
                                    case 2:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                Console.WriteLine("Ingrese nombre del catedratico:");
                                                var nombre = Console.ReadLine();
                                                Console.WriteLine("Ingrese apellido paterno:");
                                                var carrera = Console.ReadLine();
                                                Catedratico st = db.Catedraticos.Where(s => s.Nombre == nombre).Single<Catedratico>();
                                                st.Paterno = carrera;
                                                db.SaveChanges();
                                            }
                                            break; }
                                    case 3:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                Console.WriteLine("Ingrese Nombre:");
                                                var nombre = Console.ReadLine();
                                                var result = (from b in db.Catedraticos
                                                              where b.Nombre == nombre
                                                              select b).First();
                                                db.Catedraticos.Remove(result);
                                                db.SaveChanges();
                                            }
                                            break; }
                                    case 4:
                                        {
                                            using (var db = new DAL.UniversityContext())
                                            {
                                                var query = from b in db.Catedraticos
                                                            select b;
                                                foreach (var aux in query)
                                                {
                                                    Console.WriteLine(aux.CatedraticoId.ToString() + " " + aux.Nombre + " " + aux.Paterno );
                                                }
                                            }
                                            break; 
                                        }
                                }
                                Console.ReadKey();
                            }
                            while (op1 < 5);
                            break;
                            #endregion
                        }
                    case 5:
                        {
                            using (var db = new DAL.UniversityContext())
                            {
                                Console.WriteLine("Ingrese codigo de estudiante");//codigo estudiante
                                int st = Convert.ToInt32(Console.ReadLine());
                                var result = (from d in db.Inscripciones
                                              from g in db.Cursos
                                              from c in db.Materias
                                              from t in db.Notas
                                              where d.StudentId == st && g.CursoId == d.CursoId && c.MateriaId == g.MateriaId && t.InscripcionId == d.InscripcionId
                                              select new { Materia=c.Nombre, NotaFinal = t.NotaFinal ,t.Estado}).Distinct();   
                                foreach (var item in result)
                                {
                                    Console.WriteLine(item.Materia + " " + item.NotaFinal+ " "+item.Estado);
                                }
                            }
                            break; 
                        }
                    case 6:
                        {//regresa materias restantes
                            using (var db = new DAL.UniversityContext())
                            {
                                int id=Convert.ToInt32(Console.ReadLine());
                                //string nom = Console.ReadLine();
                                var subquery = from c in db.Students
                                               from d in db.Inscripciones
                                               from t in db.Cursos
                                               from p in db.Materias
                                               where c.StudentId == id && d.StudentId == c.StudentId && d.CursoId == t.CursoId && t.MateriaId == p.MateriaId
                                               select p.MateriaId;
                                var query = from l in db.Materias
                                            where l.CarreraId==1 && !subquery.Contains(l.MateriaId)
                                            select l.Nombre;
                                foreach (var item in query)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            break;
                        }
                    case 7:
                        {
                            using (var db = new DAL.UniversityContext())
                            {
                                Console.WriteLine("Introduzca el Id del curso");
                                int id=Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Introduzca el nombre de la materia");
                                string nom = Console.ReadLine();
                                var result = from d in db.Inscripciones
                                             from c in db.Students
                                             from t in db.Cursos
                                             where d.StudentId == c.StudentId && t.CursoId == d.CursoId && t.CursoId == id
                                             select new { CursoId=t.CursoId,Alumno=c.Nombre+" "+c.Paterno };
                                Console.WriteLine("Por curso:" + id.ToString());
                                foreach (var item in result)
                                {                                    
                                    Console.WriteLine( item.Alumno);
                                }
                                var res = from d in db.Inscripciones
                                          from c in db.Students
                                          from t in db.Cursos
                                          from p in db.Materias
                                          where d.StudentId == c.StudentId && t.CursoId == d.CursoId && p.MateriaId == t.MateriaId &&p.Nombre==nom
                                          select new { p.Nombre, Alumno = c.Nombre + " " + c.Paterno };
                                Console.WriteLine("Por materia:" + nom);
                                foreach (var item in res)
                                {
                                    Console.WriteLine( item.Alumno);
                                }
                            } 
                            break;
                        }
                    case 8:
                        {
                            using (var db = new DAL.UniversityContext())
                            {
                                Console.WriteLine("Ingrese nombre de la carrera");
                                string nombre=Console.ReadLine();

                                var result = (from d in db.Catedraticos
                                             from c in db.Cursos
                                             from t in db.Materias
                                             from p in db.Carreras
                                             where d.CatedraticoId == c.CatedraticoId && c.MateriaId == t.MateriaId && t.CarreraId == p.CarreraId && p.Nombre == nombre
                                             select new { Nombre = d.Nombre, Paterno = d.Paterno }).Distinct();
                                Console.WriteLine("Lista de docentes pertenecientes a: " + nombre);
                                foreach (var item in result)
                                {
                                    Console.WriteLine(item.Nombre+" "+item.Paterno);
                                }
                            } break;
                        }
                }
                Console.ReadKey();
            }
            while (op < 9);
        }
    }
}
