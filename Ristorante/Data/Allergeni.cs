using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ristorante.Data
{
    public class Allergeni
    {


        /// <summary>
        /// ID degli Allergeni
        /// </summary>
        [Required(ErrorMessage = " Inserire l' ID")]
        public int ID { get; set; }

        /// <summary>
        /// Il Allergeni_contenuti richiesto
        /// </summary>
        public string Allergeni_contenuti { get; set; }
    }
}
