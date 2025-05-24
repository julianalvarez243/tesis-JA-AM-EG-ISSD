using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class EstadoMozo
    {
        public int EstadoMozoId { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public ICollection<Mozo> Mozos { get; set; }
    }
}
