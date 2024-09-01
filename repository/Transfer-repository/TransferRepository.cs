using api_conta_corrente.Model.Transfer;

namespace api_conta_corrente.Repository {
    public class TransferRepository(AppDbContext dbContext) : ITransferRepository {

        private readonly AppDbContext _appDbContext = dbContext;

        public void CreateCreditTransfer(int id, double value) {
            TransferType type = TransferType.CREDIT;
            _appDbContext.Transfers.Add(new Transfer(id, value, type));
            _appDbContext.SaveChanges();
        }

        public void CreateDebitTransfer(int id, double value) {
            TransferType type = TransferType.DEBIT;
            _appDbContext.Transfers.Add(new Transfer(id, value, type));
            _appDbContext.SaveChanges();
        }
    }
}