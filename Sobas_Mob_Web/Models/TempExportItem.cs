using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("TempExportItem")]
public partial class TempExportItem
{
    [StringLength(15)]
    [Unicode(false)]
    public string? CustomerCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SupplierDocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SupplierDocDate { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? LineNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemDesc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FromBatchNo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? InvoiceQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SupplierInvoiceRate { get; set; }

    [Column("MRP", TypeName = "decimal(18, 3)")]
    public decimal? Mrp { get; set; }

    [Column("MFGDt", TypeName = "datetime")]
    public DateTime? Mfgdt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpDt { get; set; }

    public int? NoOfCases { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Discount2Per { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Discount2Amt { get; set; }

    [Column("SGSTPer", TypeName = "decimal(18, 2)")]
    public decimal? Sgstper { get; set; }

    [Column("SGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal? Sgstamt { get; set; }

    [Column("CGSTPer", TypeName = "decimal(18, 2)")]
    public decimal? Cgstper { get; set; }

    [Column("CGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal? Cgstamt { get; set; }

    [Column("IGSTPer", TypeName = "decimal(18, 2)")]
    public decimal? Igstper { get; set; }

    [Column("IGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal? Igstamt { get; set; }

    [Column("TSIndentNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TsindentNo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? InvoiceAmt { get; set; }

    [Column("SAPPlantCode")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SapplantCode { get; set; }

    [Column("SAPPlantName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? SapplantName { get; set; }

    [Column("TSBranchCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TsbranchCode { get; set; }
}
