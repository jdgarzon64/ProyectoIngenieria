using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoIngenieria.Controllers;
using System.Web.Mvc;

namespace ProyectoIngenieria.Tests.Controllers
{
    [TestClass]
    public class MedicoTest
    {
        [TestMethod]
        public void Create()
        {
            MedicosController me = new MedicosController();
            Medicos medico = new Medicos();
            medico.idmedico = 3;
            medico.nombre = "sergio";
            medico.apellido = "ceballos";
            medico.identificacion = "4321";


            ViewResult result = me.Create(medico) as ViewResult;


            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Search()
        {

            MedicosController me = new MedicosController();


            ViewResult result = me.Details(1) as ViewResult;


            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Delete()
        {

            MedicosController me = new MedicosController();



            ViewResult result = me.Delete(1) as ViewResult;


            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Edit()
        {
            MedicosController me = new MedicosController();
            Medicos medico = new Medicos();
            medico.idmedico = 3;
            medico.nombre = "nose";
            medico.apellido = "nise";
            medico.identificacion = "4124789";


            ViewResult result = me.Edit(medico) as ViewResult;


            Assert.IsNotNull(result);
        }
    }
}
