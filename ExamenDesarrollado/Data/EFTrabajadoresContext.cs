#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenDesarrollado.Models;

namespace ExamenDesarrollado.Data
{
    public class EFTrabajadoresContext : DbContext
    {
        public EFTrabajadoresContext (DbContextOptions<EFTrabajadoresContext> options)
            : base(options)
        {
        }

        public DbSet<ExamenDesarrollado.Models.Trabajadores> Trabajadores { get; set; }
    }
}
