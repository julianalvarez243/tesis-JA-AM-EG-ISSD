using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class EstadoCaja
    {
        public int EstadoCajaId { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public ICollection<Caja> Cajas { get; set; }
    }
}
