using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("inventorytransList_Boserver")]
public partial class InventorytransListBoserver
{
    [Column("InventoryTransListUID", TypeName = "numeric(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [Column("InventoryTransUID", TypeName = "numeric(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column(TypeName = "numeric(6, 2)")]
    public decimal LineNumber { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FromBatchNo { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal? ReceiptReturnQty { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal CarrierShortages { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal Moistureqty { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal NetQty { get; set; }

    [Column("POLineUID", TypeName = "numeric(18, 0)")]
    public decimal? PolineUid { get; set; }

    [Column("PORateUID")]
    public Guid? PorateUid { get; set; }

    [Column("PORate", TypeName = "numeric(18, 3)")]
    public decimal Porate { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal SupplierInvoiceRate { get; set; }

    [Column("MRPUID")]
    public Guid? Mrpuid { get; set; }

    [Column("MRP", TypeName = "numeric(18, 3)")]
    public decimal Mrp { get; set; }

    [Column("PriceListUID")]
    public Guid? PriceListUid { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal Rate { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal ProductVal { get; set; }

    [Column("MFGDt", TypeName = "datetime")]
    public DateTime Mfgdt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpDt { get; set; }

    [Column("ItemStatusUID")]
    public Guid? ItemStatusUid { get; set; }

    public int NoOfCases { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal Discount1Per { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal Discount2Per { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal Discount3Per { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal Discount4Per { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal Discount1Amt { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal Discount2Amt { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal Discount3Amt { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal Discount4Amt { get; set; }

    [Column("EDUID")]
    public Guid? Eduid { get; set; }

    [Column("EDPer", TypeName = "numeric(18, 2)")]
    public decimal Edper { get; set; }

    [Column("EDAmt", TypeName = "numeric(18, 3)")]
    public decimal Edamt { get; set; }

    [Column("EDCessUID")]
    public Guid? EdcessUid { get; set; }

    [Column("EDCessPer", TypeName = "numeric(18, 2)")]
    public decimal EdcessPer { get; set; }

    [Column("EDCessAmt", TypeName = "numeric(18, 3)")]
    public decimal EdcessAmt { get; set; }

    [Column("VATUID")]
    public Guid? Vatuid { get; set; }

    [Column("VATPer", TypeName = "numeric(18, 2)")]
    public decimal Vatper { get; set; }

    [Column("VATAmt", TypeName = "numeric(18, 3)")]
    public decimal Vatamt { get; set; }

    [Column("VATCessUID")]
    public Guid? VatcessUid { get; set; }

    [Column("VATCessPer", TypeName = "numeric(18, 2)")]
    public decimal VatcessPer { get; set; }

    [Column("VATCessAmt", TypeName = "numeric(18, 3)")]
    public decimal VatcessAmt { get; set; }

    [Column("SecondaryCessUID")]
    public Guid? SecondaryCessUid { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? SecondaryCessPer { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal? SecondaryCessAmt { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal LineTotal { get; set; }

    [Column("RATransLineUID", TypeName = "numeric(18, 0)")]
    public decimal? RatransLineUid { get; set; }

    [Column("SalesReturnInvTransUID", TypeName = "numeric(18, 0)")]
    public decimal? SalesReturnInvTransUid { get; set; }

    [Column("SOHeaderUID", TypeName = "numeric(18, 0)")]
    public decimal? SoheaderUid { get; set; }

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
}
