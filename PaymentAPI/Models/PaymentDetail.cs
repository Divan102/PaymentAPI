using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }
        public int CardOwnerName  { get; set; }
        public int CardNumber  { get; set; }
        public int ExpirationDate  { get; set; }
        public int SecurityCode  { get; set; }
    }
}
