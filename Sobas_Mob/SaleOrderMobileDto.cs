using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Sobas_Mob
{
    public class SaleOrderMobileDto
    {
        [JsonPropertyName("salesOrderUID")]
        public Guid SalesOrderUid { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string? PartyCode { get; set; }
        public string? PartyName { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public string? Remarks { get; set; }
        public DateTime CreatedDate { get; set; }
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int Quantity { get; set; }

        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public decimal? Rate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        //[JsonPropertyName("items")]
        [JsonIgnore]
        public List<SaleOrderMobileDto> Items { get; set; }
    }
}
