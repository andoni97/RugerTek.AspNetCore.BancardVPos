using RugerTek.AspNetCore.BancardVPOS.Constants;

namespace RugerTek.AspNetCore.BancardVPOS.Models
{
    public class BancardSingleBuyRequest
    {
        public string ShopProcessId { get; set; }
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }
        public string AdditionalData { get; set; }
        public string ReturnUrl { get; set; }
        public string CancelUrl { get; set; }
    }
}