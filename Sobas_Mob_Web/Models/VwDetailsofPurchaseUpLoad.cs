using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwDetailsofPurchaseUpLoad
{
    [StringLength(20)]
    [Unicode(false)]
    public string PurchaseInvoiceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PurchaseInvoiceDate { get; set; }

    [Column("TINNo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Tinno { get; set; }

    [Column("Name of the Seller")]
    [StringLength(172)]
    [Unicode(false)]
    public string? NameOfTheSeller { get; set; }

    [Column("Seller Dealer Address")]
    [StringLength(600)]
    [Unicode(false)]
    public string SellerDealerAddress { get; set; } = null!;

    [Column("Taxable Value", TypeName = "decimal(38, 3)")]
    public decimal? TaxableValue { get; set; }

    [Column("VAT Amount", TypeName = "decimal(38, 3)")]
    public decimal? VatAmount { get; set; }

    [Column("CESS Amount", TypeName = "decimal(38, 3)")]
    public decimal? CessAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;
}
