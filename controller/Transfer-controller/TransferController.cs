using api_conta_corrente.Messaging;
using api_conta_corrente.Service;
using Microsoft.AspNetCore.Mvc;

namespace api_conta_corrente.Controller {
    
    [ApiController]
    [Route("transfer")]
    public class TransferController(TransferService transferService, ClientAccountService clientAccountService, RabbitMQService rabbitMQService) : ControllerBase {
        
        private readonly TransferService _transferService = transferService;
        private readonly ClientAccountService _clientAccountService = clientAccountService;
        private readonly RabbitMQService _rabbitMQService = rabbitMQService;

        [HttpPost("debit")]
        public IActionResult CreateDebitTransfer([FromBody] TransferRequest reqBody) {
            double balance = _clientAccountService.GetAccountBalance(reqBody.AccountId);
    
            if(balance < reqBody.Value) {
                return BadRequest("Transfer value is greater than account balance");
            }

            _transferService.CreateDebitTransfer(reqBody.AccountId, reqBody.Value);
            _clientAccountService.UpdateAccountBalance(reqBody.AccountId, -reqBody.Value);

            _rabbitMQService.Publish("DebitTransferQueue", "New debit transfer created");

            return Ok("Debit transfer created successfully");
        }

        [HttpPost("credit")]
        public IActionResult CreateCreditTransfer([FromBody] TransferRequest reqBody) {
            _transferService.CreateCreditTransfer(reqBody.AccountId, reqBody.Value);
            _clientAccountService.UpdateAccountBalance(reqBody.AccountId, reqBody.Value);

            _rabbitMQService.Publish("creditTransferQueue", "New credit transfer created");

            return Ok("Credit transfer created successfully");
        }
    }
}