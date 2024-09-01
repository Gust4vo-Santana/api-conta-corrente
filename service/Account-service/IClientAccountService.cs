using api_conta_corrente.Model;

namespace api_conta_corrente.Service {
    public interface IClientAccountService {
        double GetAccountBalance(int id);
        void UpdateAccountBalance(int id, double value);
    }
}