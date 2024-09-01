using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_conta_corrente.Model.Transfer {
    public class Transfer {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int AccountId { get; set; }

        [Required]
        public double Value { get; set; }

        [Required]
        public TransferType Type { get; set; }


        public Transfer() {}

        public Transfer(int accountId, double value, TransferType type) {
            AccountId = accountId;
            Value = value;
            Type = type;
        }
    }
}