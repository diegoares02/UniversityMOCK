using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using System.Data.Entity;
using University.Models;
using University.DAL;

namespace NUnit_test_MOQ
{
    [TestFixture]
    public class TestMOQ
    {
        //[Test]
        //public void DeberiaAgregar()
        //{
        //    var mockSet = new Mock<DbSet<Student>>();
        //    var mockContext=new Mock<UniversityContext>();
        //    mockContext.Setup(m => m.Students).Returns(mockSet.Object);
        //    var service = new UniversityContextService(mockContext.Object);
        //    var data = new List<Student> {new Student{Nombre="Carlos",Paterno="Estrada",Materno="Copa",Telefono=2269587,Celular=7957847,Email="carlos@gmail.com",Fecha_Inscripcion=DateTime.Parse("2014-05-06")},
        //        new Student{Nombre="Pedro",Paterno="Cooper",Materno="Oropeza",Telefono=2659877,Celular=7958746,Email="pedro@gmail.com",Fecha_Inscripcion=DateTime.Parse("2014-02-03")},
        //        new Student{Nombre="Ryan",Paterno="Lopez",Materno="Campero",Telefono=2354654,Celular=7236547,Email="ryan@gmail.com",Fecha_Inscripcion=DateTime.Parse("2014-08-14")},
        //        new Student{Nombre="Andres",Paterno="Tinta",Materno="Lima",Telefono=2987564,Celular=7569875,Email="andres@gmail.com",Fecha_Inscripcion=DateTime.Parse("2015-03-09")}, };
        //    service.AddStudent(data);
        //    mockSet.Verify(m => m.Add(It.IsAny<Student>()), Times.Exactly(4));
        //    mockContext.Verify(m => m.SaveChanges(), Times.Once);
        //}
        //[Test]
        //public void DeberiActualizar()
        //{
        //    var mockSet = new Mock<DbSet<Student>>();
        //    var mockContext = new Mock<UniversityContext>();
        //    mockContext.Setup(m => m.Students).Returns(mockSet.Object);
        //    var existing = new Student { StudentId = 1, Nombre = "Carlos", Paterno = "Estrada", Materno = "Copa", Telefono = 2269587, Celular = 7957847, Email = "carlos@gmail.com", Fecha_Inscripcion = DateTime.Parse("2014-05-06") };
        //    var data = new Student 
        //    {
        //        StudentId=1,
        //        Nombre = "Carlos",
        //        Paterno = "Estrada",
        //        Materno = "Copa",
        //        Telefono = 2269587,
        //        Celular = 6592355,//esta es la actualizacion
        //        Email = "carlos@gmail.com",
        //        Fecha_Inscripcion = DateTime.Parse("2014-05-06")
        //    };
        //    var queryable = new List<Student> { data }.AsQueryable();
        //    mockSet.As<IQueryable<Student>>().Setup(m => m.Provider).Returns(queryable.Provider);
        //    mockSet.As<IQueryable<Student>>().Setup(m => m.Expression).Returns(queryable.Expression);
        //    mockSet.As<IQueryable<Student>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
        //    mockSet.As<IQueryable<Student>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());
        //    mockContext.Setup(m => m.SaveChanges()).Verifiable();

        //    var service = new UniversityContextService(mockContext.Object);
        //    service.UpdateStudent(data);
        //    var mostrar = service.Show();

        //    mockContext.Verify();
        //    Assert.AreEqual(1,mostrar.Count);
        //    Assert.AreEqual("Carlos", mostrar[0].Nombre);
        //    Assert.AreEqual(6592355, mostrar[0].Celular);
        //}
        //[Test]
        //public void DeberiaEliminar()
        //{
        //    var mockSet = new Mock<DbSet<Student>>();
        //    var mockContext = new Mock<UniversityContext>();
        //    mockContext.Setup(m => m.Students).Returns(mockSet.Object);
        //    var data = new Student { StudentId = 1, Nombre = "Carlos", Paterno = "Estrada", Materno = "Copa", Telefono = 2269587, Celular = 7957847, Email = "carlos@gmail.com", Fecha_Inscripcion = DateTime.Parse("2014-05-06") };
        //    var queryable = new List<Student> { data }.AsQueryable();
        //    mockSet.As<IQueryable<Student>>().Setup(m => m.Provider).Returns(queryable.Provider);
        //    mockSet.As<IQueryable<Student>>().Setup(m => m.Expression).Returns(queryable.Expression);
        //    mockSet.As<IQueryable<Student>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
        //    mockSet.As<IQueryable<Student>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());
        //    mockSet.Setup(m => m.Remove(data)).Verifiable();
        //    mockContext.Setup(m => m.SaveChanges()).Verifiable();
        //    var service = new UniversityContextService(mockContext.Object);
        //    service.DeleteStudent("Carlos");//elimina por nombre
        //    mockContext.Verify();
        //}
    }
}
