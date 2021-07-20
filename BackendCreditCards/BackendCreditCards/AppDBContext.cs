using BackendCreditCards.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendCreditCards
{
    public class AppDBContext : DbContext
    {
        public DbSet<CreditCard> CreditCard { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
    }
}
