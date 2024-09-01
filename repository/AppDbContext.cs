using System.Transactions;
using api_conta_corrente.Model;
using api_conta_corrente.Model.Transfer;
using Microsoft.EntityFrameworkCore;

namespace api_conta_corrente.Repository {
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options) {
        public DbSet<ClientAccount> Accounts { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
    }
}