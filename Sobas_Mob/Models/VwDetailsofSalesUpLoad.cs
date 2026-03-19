using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwDetailsofSalesUpLoad
{
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InvoiceDate { get; set; }

    [Column("TINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tinno { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("Name of the Buyer")]
    [StringLength(172)]
    [Unicode(false)]
    public string? NameOfTheBuyer { get; set; }

    [Column("Buyer Address")]
    [StringLength(600)]
    [Unicode(false)]
    public string BuyerAddress { get; set; } = null!;

    [Column("Taxable Value", TypeName = "decimal(38, 3)")]
    public decimal? TaxableValue { get; set; }

    [Column("VAT Amount", TypeName = "decimal(38, 3)")]
    public decimal? VatAmount { get; set; }

    [Column("CESS Amount", TypeName = "decimal(38, 3)")]
    public decimal? CessAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Value { get; set; }

    [Column(TypeName = "decimal(21, 3)")]
    public decimal? Discount { get; set; }

    [Column("Excise Duty", TypeName = "decimal(18, 3)")]
    public decimal ExciseDuty { get; set; }

    [Column("CESS ON ED", TypeName = "decimal(18, 3)")]
    public decimal CessOnEd { get; set; }

    [Column("VAT %", TypeName = "decimal(18, 2)")]
    public decimal Vat { get; set; }

    [Column("VAT CESS %", TypeName = "decimal(18, 2)")]
    public decimal VatCess { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string IsInterState { get; set; } = null!;
}
