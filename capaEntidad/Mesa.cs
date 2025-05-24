using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Mesa
    {
        public int MesaId { get; set; }
        [Required]
        public int NumeroMesa { get; set; }
        [Required]
        public int EstadoMesaId { get; set; }
        [Required]
        public EstadoMesa EstadoMesa { get; set; }
        [Required]
        public int TamanioId { get; set; }
        [Required]
        public Tamanio TamanioMesa { get; set; }
        public ICollection<Comanda> Comandas { get; set; }

    }
}
