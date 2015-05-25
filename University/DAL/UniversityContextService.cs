using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using University.Models;

namespace University.DAL
{
    public class UniversityContextService
    {
        //private UniversityContext _context;
        //public UniversityContextService(UniversityContext context)
        //{
        //    _context = context;
        //}
        //public List<Student> AddStudent(List<Student> student)
        //{
        //    student.ForEach(s => _context.Students.Add(s));
        //    _context.SaveChanges();
        //    return student;
        //}
        //public void UpdateStudent(Student student)
        //{
        //    int? x = student.StudentId;
        //    if (!x.HasValue)
        //    {
        //        _context.Students.Add(new Student { StudentId = student.StudentId, Nombre = student.Nombre, Paterno = student.Paterno, Materno = student.Materno, Telefono = student.Telefono, Celular = student.Celular, Email = student.Email, Fecha_Inscripcion = student.Fecha_Inscripcion });
        //        _context.SaveChanges();                
        //    }
        //    else
        //    {
        //        var entity = _context.Students.Where(s => s.StudentId == student.StudentId).Single();
        //        entity.Celular = student.Celular;
        //        _context.SaveChanges();
        //    }
        //}
        //public void DeleteStudent(string nombre)
        //{
        //    var entity = _context.Students.Where(s => s.Nombre == nombre).Single();
        //    _context.Students.Remove(entity);
        //    _context.SaveChanges();
        //}
        //public List<Student> Show()
        //{
        //    var mostrar = from d in _context.Students
        //                  select d;
        //    return mostrar.ToList();
        //}
    }
}
