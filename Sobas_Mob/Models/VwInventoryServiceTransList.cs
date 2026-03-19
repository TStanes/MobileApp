using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwInventoryServiceTransList
{
    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal LineNumber { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string BatchNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? FromBatchNo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ReceiptReturnQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CarrierShortages { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Moistureqty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetQty { get; set; }

    [Column("PONo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Pono { get; set; }

    [Column("PODate", TypeName = "datetime")]
    public DateTime? Podate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IndentNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IndentDate { get; set; }

    [Column("PORate", TypeName = "decimal(18, 3)")]
    public decimal Porate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SupplierInvoiceRate { get; set; }

    [Column("MRP", TypeName = "decimal(18, 3)")]
    public decimal Mrp { get; set; }

    [Column("PriceListUID")]
    public Guid? PriceListUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProductVal { get; set; }

    [Column("MFGDt", TypeName = "datetime")]
    public DateTime? Mfgdt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpDt { get; set; }

    [Column("ItemStatusUID")]
    public Guid? ItemStatusUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemStatusCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemStatusDescription { get; set; }

    public int? NoOfCases { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount1Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount2Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount3Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount4Per { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1Amt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2Amt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3Amt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount4Amt { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ServicePer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ServiceAmt { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ServiceCessPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ServiceCessAmt { get; set; }

    [Column("VATPer", TypeName = "decimal(18, 2)")]
    public decimal Vatper { get; set; }

    [Column("VATAmt", TypeName = "decimal(18, 3)")]
    public decimal Vatamt { get; set; }

    [Column("VATCessPer", TypeName = "decimal(18, 2)")]
    public decimal VatcessPer { get; set; }

    [Column("VATCessAmt", TypeName = "decimal(18, 3)")]
    public decimal VatcessAmt { get; set; }

    [Column("ServiceHEduCessPer", TypeName = "decimal(18, 2)")]
    public decimal? ServiceHeduCessPer { get; set; }

    [Column("ServiceHEduCessAmt", TypeName = "decimal(18, 3)")]
    public decimal? ServiceHeduCessAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LineTotal { get; set; }

    [Column("SOHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal? SoheaderUid { get; set; }

    [Column("SONumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Sonumber { get; set; }

    [Column("SODate", TypeName = "datetime")]
    public DateTime? Sodate { get; set; }

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [Column("SGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Sgstper { get; set; }

    [Column("SGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Sgstamt { get; set; }

    [Column("CGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Cgstper { get; set; }

    [Column("CGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Cgstamt { get; set; }

    [Column("IGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Igstper { get; set; }

    [Column("IGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Igstamt { get; set; }
}
