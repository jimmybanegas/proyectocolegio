using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Colegio.Models
{
    public class Tarea
    {
        public int TareaId { get; set; }

        public string Descripción { get; set; }

        public Materia MateriaId { get; set; }

        public int NotaId { get; set; }

        public virtual ICollection<Nota> Notas {get; set; }
    }
}