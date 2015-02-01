namespace Colegio.Models
{
    public class Nota
    {
        public int NotaId { get; set; }

        public int TareaId { get; set; }

        public virtual Tarea Tarea { get; set; }

        public int AlumnoId { get; set; }

        public virtual  Alumno Alumno { get; set; }

        public double Calificación { get; set; }
    }
}