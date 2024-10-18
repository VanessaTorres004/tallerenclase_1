using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tallerenclase_1.Models;

namespace tallerenclase_1.Data
{
    public class tallerenclase_1Context : DbContext
    {
        public tallerenclase_1Context (DbContextOptions<tallerenclase_1Context> options)
            : base(options)
        {
        }

        public DbSet<tallerenclase_1.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<tallerenclase_1.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<tallerenclase_1.Models.Jugadores> Jugadores { get; set; } = default!;
    }
}
