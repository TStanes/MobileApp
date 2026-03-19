using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("InventoryTransList")]
[Index("BatchNo", "FromBatchNo", Name = "IX_InventoryTransList_BatchNo_FromBatchNo_Includes")]
[Index("Qty", "ReceiptReturnQty", Name = "IX_InventoryTransList_Qty_ReceiptReturnQty_Includes")]
[Index("SalesReturnInvTransUid", Name = "IX_InventoryTransList_SalesReturnInvTransUID_Includes")]
[Index("InventoryTransListUid", "ItemUid", "InventoryTransUid", Name = "IX_Inventorytranslist_Item_TransUID")]
[Index("ItemUid", Name = "IX_ItemUID")]
[Index("PolineUid", Name = "IX_PolineUID")]
[Index("SoheaderUid", Name = "IX_SoHeader")]
[Index("ItemUid", "BatchNo", Name = "IX_itemuidBatchNo")]
[Index("BatchNo", "IsActive", Name = "NonClusteredIndex-BatchNoIsactive_itemUID")]
[Index("InventoryTransUid", "IsActive", "InventoryTransListUid", "ItemUid", "Rate", "Mfgdt", "ExpDt", Name = "_dta_index_InventoryTransList_7_231671873__K2_K52_K1_K4_K19_K21_K22_11")]
[Index("CreatedDate", "InventoryTransListUid", "InventoryTransUid", Name = "_dta_index_InventoryTransList_7_231671873__K54_K1_K2")]
public partial class InventoryTransList
{
    [Key]
    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal LineNumber { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FromBatchNo { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? ReceiptReturnQty { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal CarrierShortages { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Moistureqty { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal NetQty { get; set; }

    [Column("POLineUID", TypeName = "decimal(18, 0)")]
    public decimal? PolineUid { get; set; }

    [Column("PORateUID")]
    public Guid? PorateUid { get; set; }

    [Column("PORate", TypeName = "decimal(18, 3)")]
    public decimal Porate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SupplierInvoiceRate { get; set; }

    [Column("MRPUID")]
    public Guid? Mrpuid { get; set; }

    [Column("MRP", TypeName = "decimal(18, 3)")]
    public decimal Mrp { get; set; }

    [Column("PriceListUID")]
    public Guid? PriceListUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProductVal { get; set; }

    [Column("MFGDt", TypeName = "datetime")]
    public DateTime Mfgdt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpDt { get; set; }

    [Column("ItemStatusUID")]
    public Guid? ItemStatusUid { get; set; }

    public int NoOfCases { get; set; }

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

    [Column("EDUID")]
    public Guid? Eduid { get; set; }

    [Column("EDPer", TypeName = "decimal(18, 2)")]
    public decimal Edper { get; set; }

    [Column("EDAmt", TypeName = "decimal(18, 3)")]
    public decimal Edamt { get; set; }

    [Column("EDCessUID")]
    public Guid? EdcessUid { get; set; }

    [Column("EDCessPer", TypeName = "decimal(18, 2)")]
    public decimal EdcessPer { get; set; }

    [Column("EDCessAmt", TypeName = "decimal(18, 3)")]
    public decimal EdcessAmt { get; set; }

    [Column("VATUID")]
    public Guid? Vatuid { get; set; }

    [Column("VATPer", TypeName = "decimal(18, 2)")]
    public decimal Vatper { get; set; }

    [Column("VATAmt", TypeName = "decimal(18, 3)")]
    public decimal Vatamt { get; set; }

    [Column("VATCessUID")]
    public Guid? VatcessUid { get; set; }

    [Column("VATCessPer", TypeName = "decimal(18, 2)")]
    public decimal VatcessPer { get; set; }

    [Column("VATCessAmt", TypeName = "decimal(18, 3)")]
    public decimal VatcessAmt { get; set; }

    [Column("SecondaryCessUID")]
    public Guid? SecondaryCessUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SecondaryCessPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SecondaryCessAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LineTotal { get; set; }

    [Column("RATransLineUID", TypeName = "decimal(18, 0)")]
    public decimal? RatransLineUid { get; set; }

    [Column("SalesReturnInvTransUID", TypeName = "decimal(18, 0)")]
    public decimal? SalesReturnInvTransUid { get; set; }

    [Column("SOHeaderUID", TypeName = "decimal(18, 0)")]
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

    [Column("SGSTUID")]
    public Guid? Sgstuid { get; set; }

    [Column("SGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Sgstper { get; set; }

    [Column("SGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Sgstamt { get; set; }

    [Column("CGSTUID")]
    public Guid? Cgstuid { get; set; }

    [Column("CGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Cgstper { get; set; }

    [Column("CGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Cgstamt { get; set; }

    [Column("IGSTUID")]
    public Guid? Igstuid { get; set; }

    [Column("IGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Igstper { get; set; }

    [Column("IGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Igstamt { get; set; }

    [InverseProperty("GrnlistU")]
    public virtual ICollection<GrnoutsourceMapping> GrnoutsourceMappingGrnlistUs { get; set; } = new List<GrnoutsourceMapping>();

    [InverseProperty("OslistU")]
    public virtual ICollection<GrnoutsourceMapping> GrnoutsourceMappingOslistUs { get; set; } = new List<GrnoutsourceMapping>();

    [ForeignKey("InventoryTransUid")]
    [InverseProperty("InventoryTransLists")]
    public virtual InventoryTran InventoryTransU { get; set; } = null!;

    [ForeignKey("ItemStatusUid")]
    [InverseProperty("InventoryTransLists")]
    public virtual ItemStatusM? ItemStatusU { get; set; }

    [ForeignKey("ItemUid")]
    [InverseProperty("InventoryTransLists")]
    public virtual ItemM ItemU { get; set; } = null!;

    [InverseProperty("InventoryTransListU")]
    public virtual MOpeningRate? MOpeningRate { get; set; }
}
