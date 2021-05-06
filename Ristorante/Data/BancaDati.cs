using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ristorante.Data
{
    public class BancaDati : DbContext
	{

		/// <summary>
		/// Gestisce la connessione del database al Ristorante
		/// </summary>
		public DbSet<Piatto> piatti { get; set; }

		public DbSet<Portata> portate { get; set; }

		public DbSet<Allergeni> allergeni { get; set; }
		public BancaDati(DbContextOptions options) : base(options) { }
	}
}
