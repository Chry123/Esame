using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ristorante.Data
{
    public class Portata
    {
        /// <summary>
        /// ID del piatto
        /// </summary>
        [Required(ErrorMessage = " Inserire l' ID")]
        public int ID { get; set; }

        /// <summary>
        /// Il Tipo_portata richiesto
        /// </summary>
        public string Tipo_portata { get; set; }
    }
}
