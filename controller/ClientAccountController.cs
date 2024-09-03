using api_conta_corrente.Service;
using Microsoft.AspNetCore.Mvc;

namespace api_conta_corrente.Controller {

    [ApiController]
    [Route("account")]
    public class ClientAccountController(IClientAccountService clientAccountService) : ControllerBase {

        private readonly IClientAccountService _clientAccountService = clientAccountService;
        

        [HttpGet("{id}")]
        public IActionResult GetAccountBalance(int id) {
            double balance = _clientAccountService.GetAccountBalance(id);

            return Ok(balance);
        }
    }
}