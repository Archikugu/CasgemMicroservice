using CasgemMicroservice.Services.Cargo.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.DataAccess.Context
{
    public class CargoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433;database=CasgemCargoDb;user=sa;password=123456789Aa*");
        }
        public DbSet<CargoDetail> CargoDetails { get; set; }
        public DbSet<CargoState> CargoStates { get; set; }
    }
}
