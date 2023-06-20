using BLData.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLogica.Interfaces
{
    public interface ILogica
    {
         List<ListAlumnoViewModel> GetListAlumno();
        AlumnoViewModel CreateNewAlumno(AlumnoViewModel model);
        AlumnoViewModel EditarAlumno(AlumnoViewModel model);
        

    }
}
