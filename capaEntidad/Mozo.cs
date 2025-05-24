﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Mozo
    {
        public int MozoId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int EstadoMozoId { get; set; }
        [Required]
        public EstadoMozo EstadoMozo { get; set; }
        public ICollection<Mesa> Mesas { get; set; }

    }
}
