using System.ComponentModel.DataAnnotations;

namespace BackendCreditCards.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        [Required]
        public string cardOwner { get; set; }
        [Required]
        public string cardNum { get; set; }
        [Required]
        public string expirationDate { get; set; }
        [Required]
        public int cvv { get; set; }
    }
}
