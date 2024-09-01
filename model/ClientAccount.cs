
using System.ComponentModel.DataAnnotations;
using api_conta_corrente.Model.Transfer;

namespace api_conta_corrente.Model {
    public class ClientAccount {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ClientName { get; set; }

        [Required]
        public double AccountBalance { get; set; }

        public ClientAccount() {}

        public ClientAccount(int id, string clientName, double accountBalance) {
            Id =id;
            ClientName = clientName;
            AccountBalance = accountBalance;
        }
    }

}