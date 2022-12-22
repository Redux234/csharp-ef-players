using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    public class CreazioneDatabase : DbContext
    {
        public DbSet<Player> Player { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=Esercizio;" +
                "Integrated Security=true;TrustServerCertificate=True");
        }
    }
}
