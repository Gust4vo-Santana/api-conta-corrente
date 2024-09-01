namespace api_conta_corrente.Repository {
    public interface ITransferRepository {
        void CreateDebitTransfer(int id, double value);
        void CreateCreditTransfer(int id, double value);
    }
}