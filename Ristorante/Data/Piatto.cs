using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ristorante.Data
{
    public class Piatto
    {

        /// <summary>
        /// ID del piatto
        /// </summary>
        [Required(ErrorMessage = " Inserire l' ID")]
        public int ID { get; set; }

        /// <summary>
        /// La Stagione_presentazione richieste
        /// </summary>
        public string Stagione_presentazione { get; set; }

        /// <summary>
        /// Il Prezzo del piatto
        /// </summary>
        [Required(ErrorMessage = " Inserire il Prezzo")]
        public double Prezzo { get; set; }

        /// <summary>
        /// Qui viene messa una convalida richiedere la portata del piatto
        /// </summary>
        public int ID_portate { get; set; }

        /// <summary>
        /// Gli Allergeni_contenuti richiesti
        /// </summary>
        public int ID_Allergeni_contenuti { get; set; }
    }
}
