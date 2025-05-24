using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Tamanio
    {
        public int TamanioId { get; set; }
        
        public string? Descripcion { get; set; }
        [Required]
        public int Capacidad { get; set; }
        public ICollection<Mesa> Mesas { get; set; }
    }
}
