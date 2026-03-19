using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ItemM")]
[Index("ItemUid", "IsEd", "IsActive", "ItemDesc", "ItemSegmentUid", "ItemCode", Name = "_dta_index_ItemM_5_1995154153__K1_K30_K23_K3_K5_K2_17")]
public partial class ItemM
{
    [Key]
    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column("ItemCategoryUID")]
    public Guid ItemCategoryUid { get; set; }

    [Column("ItemSegmentUID")]
    public Guid ItemSegmentUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    [Column("UOMUID")]
    public Guid Uomuid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    public bool IsFillMaterial { get; set; }

    [Column("ABCClass")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Abcclass { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? NoOfPack { get; set; }

    [Column("ROL", TypeName = "decimal(10, 2)")]
    public decimal? Rol { get; set; }

    [Column("ROQ", TypeName = "decimal(10, 2)")]
    public decimal? Roq { get; set; }

    [Column("EOQ", TypeName = "decimal(10, 2)")]
    public decimal? Eoq { get; set; }

    [Column("ChemicalUID")]
    public Guid? ChemicalUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Specification { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RejectionReason { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RequestNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OldItemCode { get; set; }

    [Column("IsED")]
    public bool IsEd { get; set; }

    [Column("UOM2UID")]
    public Guid? Uom2uid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ConversionFactor { get; set; }

    [ForeignKey("BranchUid")]
    [InverseProperty("ItemMs")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("ChemicalUid")]
    [InverseProperty("ItemMs")]
    public virtual ChemicalM? ChemicalU { get; set; }

    [InverseProperty("ItemU")]
    public virtual ICollection<ConsignmentDetail> ConsignmentDetails { get; set; } = new List<ConsignmentDetail>();

    [InverseProperty("ItemU")]
    public virtual ICollection<DiscountItemLink> DiscountItemLinks { get; set; } = new List<DiscountItemLink>();

    [InverseProperty("ItemU")]
    public virtual ICollection<EdchargesM> EdchargesMs { get; set; } = new List<EdchargesM>();

    [InverseProperty("ItemU")]
    public virtual ICollection<Edmaster> Edmasters { get; set; } = new List<Edmaster>();

    [InverseProperty("SelectedItemU")]
    public virtual ICollection<FreeItemM> FreeItemMs { get; set; } = new List<FreeItemM>();

    [InverseProperty("FreeItemU")]
    public virtual ICollection<FreeItemQty> FreeItemQties { get; set; } = new List<FreeItemQty>();

    [InverseProperty("ItemU")]
    public virtual ICollection<FreightChargesM> FreightChargesMs { get; set; } = new List<FreightChargesM>();

    [InverseProperty("ItemU")]
    public virtual ICollection<InventoryServiceTransList> InventoryServiceTransLists { get; set; } = new List<InventoryServiceTransList>();

    [InverseProperty("ItemU")]
    public virtual ICollection<InventoryTransList> InventoryTransLists { get; set; } = new List<InventoryTransList>();

    [ForeignKey("ItemCategoryUid")]
    [InverseProperty("ItemMs")]
    public virtual ItemCategoryM ItemCategoryU { get; set; } = null!;

    [InverseProperty("ItemU")]
    public virtual ICollection<ItemCommodity> ItemCommodities { get; set; } = new List<ItemCommodity>();

    [InverseProperty("ItemU")]
    public virtual ICollection<ItemDivisionLink> ItemDivisionLinks { get; set; } = new List<ItemDivisionLink>();

    [InverseProperty("ItemU")]
    public virtual ICollection<ItemDivisionPrincipleLink> ItemDivisionPrincipleLinks { get; set; } = new List<ItemDivisionPrincipleLink>();

    [ForeignKey("ItemGroupUid")]
    [InverseProperty("ItemMs")]
    public virtual ItemGroupM ItemGroupU { get; set; } = null!;

    [InverseProperty("ItemU")]
    public virtual ICollection<ItemPrincipleSerialNoLink> ItemPrincipleSerialNoLinks { get; set; } = new List<ItemPrincipleSerialNoLink>();

    [InverseProperty("ItemU")]
    public virtual ICollection<ItemRate> ItemRates { get; set; } = new List<ItemRate>();

    [InverseProperty("ItemU")]
    public virtual ICollection<ItemRequestPack> ItemRequestPacks { get; set; } = new List<ItemRequestPack>();

    [InverseProperty("ItemU")]
    public virtual ICollection<ItemSeedM> ItemSeedMs { get; set; } = new List<ItemSeedM>();

    [ForeignKey("ItemSegmentUid")]
    [InverseProperty("ItemMs")]
    public virtual ItemSegmentM ItemSegmentU { get; set; } = null!;

    [ForeignKey("ItemSubGroupUid")]
    [InverseProperty("ItemMs")]
    public virtual ItemSubGroupM ItemSubGroupU { get; set; } = null!;

    [InverseProperty("ItemU")]
    public virtual ICollection<ItemSupplierLink> ItemSupplierLinks { get; set; } = new List<ItemSupplierLink>();

    [InverseProperty("ItemU")]
    public virtual ICollection<Podetail> Podetails { get; set; } = new List<Podetail>();

    [InverseProperty("ItemU")]
    public virtual ICollection<Poindent> Poindents { get; set; } = new List<Poindent>();

    [InverseProperty("ItemU")]
    public virtual ICollection<ProcessChargesM> ProcessChargesMs { get; set; } = new List<ProcessChargesM>();

    [InverseProperty("FinishedItemU")]
    public virtual ICollection<ProductionM> ProductionMFinishedItemUs { get; set; } = new List<ProductionM>();

    [InverseProperty("RawMatU")]
    public virtual ICollection<ProductionM> ProductionMRawMatUs { get; set; } = new List<ProductionM>();

    [InverseProperty("ItemU")]
    public virtual ICollection<ProductionQrcodeItemDetail> ProductionQrcodeItemDetails { get; set; } = new List<ProductionQrcodeItemDetail>();

    [InverseProperty("ItemU")]
    public virtual ICollection<ProformaInvoiceDetail> ProformaInvoiceDetails { get; set; } = new List<ProformaInvoiceDetail>();

    [ForeignKey("StatusUid")]
    [InverseProperty("ItemMs")]
    public virtual StatusM StatusU { get; set; } = null!;

    [InverseProperty("ItemU")]
    public virtual ICollection<StockPointCommissionDetailNew> StockPointCommissionDetailNews { get; set; } = new List<StockPointCommissionDetailNew>();

    [InverseProperty("ItemU")]
    public virtual ICollection<TaxM> TaxMs { get; set; } = new List<TaxM>();

    [ForeignKey("Uom2uid")]
    [InverseProperty("ItemMUom2us")]
    public virtual Uomm? Uom2u { get; set; }

    [ForeignKey("Uomuid")]
    [InverseProperty("ItemMUomus")]
    public virtual Uomm Uomu { get; set; } = null!;
}
