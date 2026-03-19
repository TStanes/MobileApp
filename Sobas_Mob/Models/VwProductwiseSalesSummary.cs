using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwProductwiseSalesSummary
{
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Product { get; set; } = null!;

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Qty { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Value { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Discount { get; set; }

    [Column("Excise Duty", TypeName = "decimal(38, 3)")]
    public decimal? ExciseDuty { get; set; }

    [Column("CESS ON ED", TypeName = "decimal(38, 3)")]
    public decimal? CessOnEd { get; set; }

    [Column("Taxable Value", TypeName = "decimal(38, 3)")]
    public decimal? TaxableValue { get; set; }

    [Column("VAT %", TypeName = "decimal(18, 2)")]
    public decimal Vat { get; set; }

    [Column("VAT Amount", TypeName = "decimal(38, 3)")]
    public decimal? VatAmount { get; set; }

    [Column("VAT CESS %", TypeName = "decimal(18, 2)")]
    public decimal VatCess { get; set; }

    [Column("VAT CESS AMOUNT", TypeName = "decimal(38, 3)")]
    public decimal? VatCessAmount { get; set; }

    [Column("TOTALAMOUNT", TypeName = "decimal(38, 3)")]
    public decimal? Totalamount { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Commodity { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string CommodityCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;
}
