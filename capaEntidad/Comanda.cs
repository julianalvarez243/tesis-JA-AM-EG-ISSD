using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Comanda
    {
        public int ComandaId { get; set; }
        [Required]
        public int MesaId { get; set; }
        [Required]
        public Mesa Mesa { get; set; }
        public int? ComidaId { get; set; }
        public Comida? Comida { get; set; }
        public int? BebidaId { get; set; }
        public Bebida? Bebida { get; set; }
        [Required]
        public int EstadoComandaId { get; set; }
        [Required]
        public EstadoComanda EstadoComanda { get; set; }
        [Required]
        public int CantComensales { get; set; }
        public string? Comentario { get; set; }
    }
}
