using System.ComponentModel.DataAnnotations;

namespace Sobas_Mob_Web
{
    public class SaleOrderMobileDto
    {
        public Guid SalesOrderUid { get; set; }
        
        public string PartyCode { get; set; } = "";
        public string OrderNo { get; set; } = "";
        public string PartyName { get; set; } = "";

        [Required]
        public string ItemCode { get; set; } = "";
        [Required]
        public string ItemDescription { get; set; } = "";

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }
        public decimal? Rate { get; set; }

        [Required]
        public string Remarks { get; set; } = "";

        public decimal Amount { get; set; }
        public string CreatedBy { get; set; }
        
    }
}
