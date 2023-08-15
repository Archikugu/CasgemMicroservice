using Microsoft.EntityFrameworkCore;

namespace CasgemMicroservice.Services.Payment.WebAPI.DAL
{
    public class PaymentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433;database=CasgemPaymentDb;user=sa;password=123456789Aa*");
        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
