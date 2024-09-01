using api_conta_corrente.Model;

namespace api_conta_corrente.Repository {
    public class ClientAccountRepository(AppDbContext dbContext) : IClientAccountRepository {

        private readonly AppDbContext appDbContext = dbContext;

        public void UpdateAccountBalance(int id, double value) {
            ClientAccount account = getAccountData(id);
            account.AccountBalance += value;
            dbContext.Accounts.Attach(account);
            dbContext.Entry(account).Property(p => p.AccountBalance).IsModified = true;
            dbContext.SaveChanges();
        }

        public double GetAccountBalance(int id) {
            return appDbContext.Accounts.Where(c => c.Id == id).Select(c => c.AccountBalance).Single();
        }

        public ClientAccount getAccountData(int id) {
            ClientAccount? account = appDbContext.Accounts.Find(id) ?? throw new KeyNotFoundException("Account not found");
            return account;
        }
    }
}