using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoIngenieria.Controllers;
using System.Web.Mvc;

namespace ProyectoIngenieria.Tests.Controllers
{
    [TestClass]
    public class MedicosTest
    {
        [TestMethod]
        public void Crear()
        {
            MedicosController me = new MedicosController();
            Medicos medico = new Medicos();
            medico.idmedico = 1;
            medico.nombre = "prueba crear";
            medico.apellido = "prueba create";
            medico.identificacion = "1234";


            ViewResult result = me.Create(medico) as ViewResult;


            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Buscar()
        {

            MedicosController me = new MedicosController();
            
            
            ViewResult result = me.Details(1) as ViewResult;


            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Eliminar()
        {

            MedicosController me = new MedicosController();
           


            ViewResult result = me.Delete(1) as ViewResult;


            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Editar()
        {
            MedicosController me = new MedicosController();
            Medicos medico = new Medicos();
            medico.idmedico = 1;
            medico.nombre = "lol";
            medico.apellido = "lel";
            medico.identificacion = "1234 nueva";


            ViewResult result = me.Edit(medico) as ViewResult;


            Assert.IsNotNull(result);
        }
    }
}
