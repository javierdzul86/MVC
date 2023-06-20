using BLLogica.Interfaces;
using BLData.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace BLLogica.Logica
{
    public class Logica : ILogica
    {

        public List<ListAlumnoViewModel> GetListAlumno()
        {
            List<ListAlumnoViewModel> lst;
            using (MVCCrudEntities db = new MVCCrudEntities())
            {
                lst = (from d in db.Alumno
                       select new ListAlumnoViewModel
                       {
                           Id = d.id,
                           Nombre = d.nombre,
                           Correo = d.correo
                       }).ToList();

            }

            return lst;
        }


        public AlumnoViewModel CreateNewAlumno(AlumnoViewModel model)

        {

            using (MVCCrudEntities db = new MVCCrudEntities())
            {
                var oTable = new Alumno();
                oTable.correo = model.Correo;
                oTable.fecha_nacimiento = model.Fecha_Nacimiento;
                oTable.nombre = model.Nombre;

                db.Alumno.Add(oTable);
                db.SaveChanges();
            }

             return (model);

        }

       
        public AlumnoViewModel EditarAlumno(AlumnoViewModel model)
        {
            using (MVCCrudEntities db = new MVCCrudEntities())
            {
                var oTable = db.Alumno.Find(model.Id);
                oTable.correo = model.Correo;
                oTable.fecha_nacimiento = model.Fecha_Nacimiento;
                oTable.nombre = model.Nombre;

                db.Entry(oTable).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return (model);
        }
        
    }
}
