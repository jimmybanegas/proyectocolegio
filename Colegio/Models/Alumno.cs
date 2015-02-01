using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentitySample.Models;

namespace Colegio.Models
{
    public class Alumno : ApplicationUser
    {
        public string NombrePadre { get; set; }

        public string NombreMadre{ get; set; }

        public int Telefono { get; set; }

        public int CursoId { get; set; }

        public virtual Curso Curso { get; set; }

        public virtual ICollection<Nota> Notas { get; set; }
    }
}