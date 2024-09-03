using api_conta_corrente.Service;
using api_conta_corrente.Repository;
using Moq;
using Xunit;

namespace api_conta_corrente.Tests.Service
{
    public class TransferServiceTests
    {
        private readonly Mock<ITransferRepository> _mockRepository;
        private readonly TransferService _transferService;

        public TransferServiceTests()
        {
            _mockRepository = new Mock<ITransferRepository>();
            _transferService = new TransferService(_mockRepository.Object);
        }

        [Fact]
        public void CreateCreditTransfer_ShouldCallRepositoryWithCorrectParameters()
        {
            int accountId = 1;
            double value = 200.0;

            _transferService.CreateCreditTransfer(accountId, value);

            _mockRepository.Verify(repo => repo.CreateCreditTransfer(accountId, value), Times.Once);
        }

        [Fact]
        public void CreateDebitTransfer_ShouldCallRepositoryWithCorrectParameters()
        {
            int accountId = 1;
            double value = 150.0;

            _transferService.CreateDebitTransfer(accountId, value);

            _mockRepository.Verify(repo => repo.CreateDebitTransfer(accountId, value), Times.Once);
        }
    }
}
