using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Purchase_DiscountCorrection")]
public partial class PurchaseDiscountCorrection
{
    [Column("PurchaseInvoicedetailUID")]
    public double? PurchaseInvoicedetailUid { get; set; }

    public double? BranchCode { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    public double? DivisionCode { get; set; }

    [StringLength(255)]
    public string? Abbriviation { get; set; }

    [StringLength(255)]
    public string? PurchaseInvoiceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PurchaseInvoiceDate { get; set; }

    [StringLength(255)]
    public string? SupplierCode { get; set; }

    [Column("supplierName")]
    [StringLength(255)]
    public string? SupplierName { get; set; }

    public double? ItemCode { get; set; }

    [StringLength(255)]
    public string? ItemDesc { get; set; }

    public double? SupplierInvRate { get; set; }

    public double? NetQty { get; set; }

    [Column("lineGrossAmount")]
    public double? LineGrossAmount { get; set; }

    public double? Discount1 { get; set; }

    public double? Discount2 { get; set; }

    public double? Discount3 { get; set; }

    public double? Discount4 { get; set; }

    public double? LineNetAmount { get; set; }

    public double? NetAmount { get; set; }

    [StringLength(255)]
    public string? F21 { get; set; }

    public double? F22 { get; set; }

    [StringLength(255)]
    public string? F23 { get; set; }

    [StringLength(255)]
    public string? F24 { get; set; }
}
