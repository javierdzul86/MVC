using BLData.Modelos;
using BLLogica.Interfaces;
using BLLogica.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrud.Controllers
{
    public class AlumnoController : Controller
    {

        private readonly ILogica _repository;
        public AlumnoController(ILogica repository)
        {
            this._repository = repository;
        }

        // GET: Alumno
        public ActionResult Index()
        {
            
        
            return View(_repository.GetListAlumno());
        }

        [HttpGet]
        public ActionResult Nuevo()
        {
            Alumno ob = new Alumno();
            return View(ob);
        }

        [HttpPost]
        public ActionResult Nuevo(AlumnoViewModel model)
        {
            if (ModelState.IsValid)
            {
                Redirect("~/Alumno/");
                return View(_repository.CreateNewAlumno(model));
            }
            else
            {
                throw new InvalidCastException("Error de validacion");
            }
                

        }
        public ActionResult Editar(int Id)
        {


            Alumno model = new Alumno();
            using (MVCCrudEntities db = new MVCCrudEntities())
            {
                var oTable = db.Alumno.Find(Id);
                model.nombre = oTable.nombre;
                model.correo = oTable.correo;
                model.fecha_nacimiento = (DateTime)oTable.fecha_nacimiento;
                model.id = oTable.id;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Editar(AlumnoViewModel model)
        {
           
                if (ModelState.IsValid)
                {
                Redirect("~/Alumno/");
                return View(_repository.EditarAlumno(model));

                }
                 
                 else
                 {
                throw new InvalidCastException("error de validacion");
                 }

        }
        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            Alumno model = new Alumno();
            using (MVCCrudEntities db = new MVCCrudEntities())
            {

                var oTable = db.Alumno.Find(id);
                db.Alumno.Remove(oTable);
                db.SaveChanges();
            }
            return Redirect("~/Alumno/");
        }
    }
}