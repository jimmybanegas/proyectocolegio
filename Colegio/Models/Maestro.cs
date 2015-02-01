using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentitySample.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Colegio.Models
{
    public class Maestro : ApplicationUser
    {
        
        public int Telefono { get; set; }

        public virtual ICollection<Materia> Clases { get; set; } 
    }
}