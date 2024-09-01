namespace api_conta_corrente.Service {
    public interface ITransferService {
        void CreateDebitTransfer(int accountId, double value);
        void CreateCreditTransfer(int accountId, double value);
    }
}