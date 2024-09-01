using api_conta_corrente.Model;
using api_conta_corrente.Repository;

namespace api_conta_corrente.Service {
    public class ClientAccountService(ClientAccountRepository clientAccountRepo) : IClientAccountService {

        private readonly ClientAccountRepository clientAccountRepository = clientAccountRepo;

        public double GetAccountBalance(int id) {
            return clientAccountRepository.GetAccountBalance(id);
        }

        public void UpdateAccountBalance(int id, double value) {
            clientAccountRepository.UpdateAccountBalance(id, value);
        }
    }
}