using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Factura
    {
        public int FacturaId { get; set; }
        [Required]
        public int ComandaId { get; set; }
        public Comanda Comanda { get; set; }
        [Required]
        public MetodoPago MetodoPago { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
    }
}
