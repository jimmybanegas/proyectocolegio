using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Colegio.Models
{
    public class Curso
    {
        public int CursoId { get; set; }

        public string Nombre { get; set; }

        //Encargado
        public int MaestroId { get; set; }

        public virtual Maestro Maestro { get; set; }

        public virtual ICollection<Materia> Materias { get; set; }

        public virtual ICollection<Alumno> Alumnos { get; set; } 
    }
}