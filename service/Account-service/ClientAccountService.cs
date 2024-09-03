using api_conta_corrente.Repository;

namespace api_conta_corrente.Service
{
    public class ClientAccountService(IClientAccountRepository clientAccountRepo) : IClientAccountService
    {
        private readonly IClientAccountRepository _clientAccountRepository = clientAccountRepo;

        public double GetAccountBalance(int id)
        {
            return _clientAccountRepository.GetAccountBalance(id);
        }

        public void UpdateAccountBalance(int id, double value)
        {
            _clientAccountRepository.UpdateAccountBalance(id, value);
        }
    }
}
