using api_conta_corrente.Repository;

namespace api_conta_corrente.Service {
    public class TransferService(TransferRepository transferRepository) : ITransferService {

        private readonly TransferRepository _transferRepository = transferRepository;

        public void CreateCreditTransfer(int accountId, double value) {
            _transferRepository.CreateCreditTransfer(accountId, value);
        }

        public void CreateDebitTransfer(int accountId, double value) {
            _transferRepository.CreateDebitTransfer(accountId, value);
        }
    }
}