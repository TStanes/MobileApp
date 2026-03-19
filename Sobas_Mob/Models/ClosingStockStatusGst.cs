using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ClosingStockStatusGst")]
public partial class ClosingStockStatusGst
{
    [Column("division")]
    [StringLength(255)]
    public string? Division { get; set; }

    [StringLength(255)]
    public string? ItemCategoryDesc { get; set; }

    [StringLength(255)]
    public string? Statecode { get; set; }

    [StringLength(255)]
    public string? BranchCode { get; set; }

    [StringLength(255)]
    public string? StateName { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    [Column("Item Desc")]
    [StringLength(255)]
    public string? ItemDesc { get; set; }

    [StringLength(255)]
    public string? Itemcode { get; set; }

    [Column("GST Dealer Rate")]
    public double? GstDealerRate { get; set; }

    public double? Stock { get; set; }

    [StringLength(255)]
    public string? Remarks { get; set; }

    public double? Value { get; set; }

    [Column("docno")]
    [StringLength(255)]
    public string? Docno { get; set; }

    [Column("Stock-Age")]
    public double? StockAge { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Docdate { get; set; }

    [Column("grnqty")]
    public double? Grnqty { get; set; }

    [Column("MRP")]
    public double? Mrp { get; set; }

    [Column("purqty")]
    public double? Purqty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdjDate { get; set; }

    [StringLength(255)]
    public string? AdjNo { get; set; }

    [Column("stnrdate", TypeName = "datetime")]
    public DateTime? Stnrdate { get; set; }

    [Column("STNRNO")]
    [StringLength(255)]
    public string? Stnrno { get; set; }

    [Column("PRADATE", TypeName = "datetime")]
    public DateTime? Pradate { get; set; }

    [Column("PRANO")]
    [StringLength(255)]
    public string? Prano { get; set; }

    [Column("BranchUID")]
    [StringLength(255)]
    public string? BranchUid { get; set; }

    public double? Rate { get; set; }

    public double? Porate { get; set; }

    public double? SupplierInvRate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PurchaseInvoiceDate { get; set; }

    [StringLength(255)]
    public string? PurchaseInvoiceNo { get; set; }

    [Column("party")]
    [StringLength(255)]
    public string? Party { get; set; }

    [StringLength(255)]
    public string? Partyname { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SupplierInvoiceDate { get; set; }

    [StringLength(255)]
    public string? SupplierInvoiceNo { get; set; }

    [StringLength(255)]
    public string? ItemGroupDesc { get; set; }

    [Column("ItemUID")]
    [StringLength(255)]
    public string? ItemUid { get; set; }

    [StringLength(255)]
    public string? BatchText { get; set; }

    [StringLength(255)]
    public string? ItemSubGroupDesc { get; set; }

    [Column("MFG-Age")]
    public double? MfgAge { get; set; }

    [Column("MFGdt", TypeName = "datetime")]
    public DateTime? Mfgdt { get; set; }

    [Column("Stk-Age")]
    public double? StkAge { get; set; }

    [Column("EXPdt", TypeName = "datetime")]
    public DateTime? Expdt { get; set; }

    [StringLength(255)]
    public string? SupAdd2 { get; set; }

    [StringLength(255)]
    public string? SupAdd3 { get; set; }

    [StringLength(255)]
    public string? SupAdd4 { get; set; }

    [Column("GSTNo")]
    [StringLength(255)]
    public string? Gstno { get; set; }

    [StringLength(255)]
    public string? SupCity { get; set; }

    [StringLength(255)]
    public string? State { get; set; }

    [StringLength(255)]
    public string? SupAdd1 { get; set; }

    [StringLength(255)]
    public string? Supinvno { get; set; }

    [Column("supinvdate")]
    [StringLength(255)]
    public string? Supinvdate { get; set; }

    public double? SepStock { get; set; }

    [StringLength(255)]
    public string? OctStock { get; set; }

    [Column("issueDocno")]
    [StringLength(255)]
    public string? IssueDocno { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Issuedate { get; set; }

    public double? Mvg { get; set; }

    [StringLength(255)]
    public string? NovStock { get; set; }

    [StringLength(255)]
    public string? DecStock { get; set; }
}
