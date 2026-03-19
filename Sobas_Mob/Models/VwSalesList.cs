using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwSalesList
{
    [Column(TypeName = "decimal(18, 0)")]
    public decimal Invoiceid { get; set; }

    [Column("invlistno", TypeName = "decimal(18, 0)")]
    public decimal Invlistno { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("qty", TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column("rate", TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

    [Column("MRPRate", TypeName = "decimal(18, 3)")]
    public decimal Mrprate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? CatWight { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BoundleNo { get; set; }

    [Column("ED", TypeName = "decimal(18, 2)")]
    public decimal Ed { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal LocalTax { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Surcharge { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AddSurcharge { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Cess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AccessChgs { get; set; }

    [Column("EDAMT", TypeName = "decimal(18, 3)")]
    public decimal Edamt { get; set; }

    [Column("LocaTaxAMT", TypeName = "decimal(18, 3)")]
    public decimal LocaTaxAmt { get; set; }

    [Column("SurchargeAMT", TypeName = "decimal(18, 3)")]
    public decimal? SurchargeAmt { get; set; }

    [Column("AddSurchargeAMT", TypeName = "decimal(18, 3)")]
    public decimal? AddSurchargeAmt { get; set; }

    [Column("CessAMT", TypeName = "decimal(18, 3)")]
    public decimal CessAmt { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ReSalesTax { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ResalesAmt { get; set; }

    [Column("Discount1AMT", TypeName = "decimal(18, 3)")]
    public decimal Discount1Amt { get; set; }

    [Column("Discount2AMT", TypeName = "decimal(18, 3)")]
    public decimal Discount2Amt { get; set; }

    [Column("Discount3AMT", TypeName = "decimal(18, 3)")]
    public decimal Discount3Amt { get; set; }

    [Column("Discount4AMT", TypeName = "decimal(18, 3)")]
    public decimal Discount4Amt { get; set; }

    public int NoOfCase { get; set; }

    public int Deleted { get; set; }

    [Column("Total_Amt", TypeName = "decimal(37, 6)")]
    public decimal? TotalAmt { get; set; }

    [Column("costvalue", TypeName = "decimal(37, 6)")]
    public decimal? Costvalue { get; set; }

    [Column("BILLQTY", TypeName = "decimal(18, 3)")]
    public decimal Billqty { get; set; }

    [Column("SR")]
    public int? Sr { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Segment { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Group { get; set; } = null!;

    [Column("UOM")]
    [StringLength(50)]
    [Unicode(false)]
    public string Uom { get; set; } = null!;

    [Column("UOMAbbr")]
    [StringLength(150)]
    [Unicode(false)]
    public string Uomabbr { get; set; } = null!;

    [Column("vat4", TypeName = "decimal(18, 3)")]
    public decimal Vat4 { get; set; }

    [Column("vat12", TypeName = "decimal(18, 3)")]
    public decimal? Vat12 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount1Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount2Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount3per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount4per { get; set; }
}
