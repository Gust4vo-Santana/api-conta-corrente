namespace api_conta_corrente.Repository {
    public interface IClientAccountRepository {
        double GetAccountBalance(int id);
        void UpdateAccountBalance(int id, double value);
    }
}