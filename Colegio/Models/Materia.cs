using System.Collections.Generic;

namespace Colegio.Models
{
    public class Materia
    {
        public int MateriaId { get; set; }

        public string Nombre { get; set; }

        public int CursoId { get; set; }

        public virtual Curso Curso { get; set; }

        public int MaestroId { get; set; }

        public virtual Maestro Maestro { get; set; }

        public virtual ICollection<Tarea> Tareas { get; set; } 
    }
}