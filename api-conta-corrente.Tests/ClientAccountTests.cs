using api_conta_corrente.Service;
using Xunit;
using Moq;
using api_conta_corrente.Repository;

namespace api_conta_corrente.Tests
{

    public class ClientAccountServicesTests
    {
        private readonly Mock<IClientAccountRepository> _mockRepository;
        private readonly ClientAccountService _accountService;

        public ClientAccountServicesTests()
        {
            _mockRepository = new Mock<IClientAccountRepository>();
            _accountService = new ClientAccountService(_mockRepository.Object);
        }

        [Fact]
        public void GetAccountBalance_ShouldReturnCorrectBalance()
        {
            int accountId = 1;
            double expectedBalance = 100;

            _mockRepository.Setup(repository => repository.GetAccountBalance(accountId)).Returns(expectedBalance);

            double actualBalance = _accountService.GetAccountBalance(accountId);

            Assert.Equal(expectedBalance, actualBalance);
        }

        [Fact]
        public void UpdateAccountBalance_ShouldCallRepositoryWithCorrectParameters()
        {
            int accountId = 1;
            double newBalance = 150.0;

            _accountService.UpdateAccountBalance(accountId, newBalance);

            _mockRepository.Verify(repo => repo.UpdateAccountBalance(accountId, newBalance), Times.Once);
        }
    }
}