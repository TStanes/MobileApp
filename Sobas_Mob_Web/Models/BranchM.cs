using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("BranchM")]
public partial class BranchM
{
    [Key]
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address2 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address3 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address4 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TelephoneNo { get; set; } = null!;

    [Column("CST")]
    [StringLength(50)]
    [Unicode(false)]
    public string Cst { get; set; } = null!;

    [Column("TNGST")]
    [StringLength(20)]
    [Unicode(false)]
    public string Tngst { get; set; } = null!;

    [Column("ParentBranchUID")]
    public Guid? ParentBranchUid { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BranchType { get; set; } = null!;

    public bool IsCostCal { get; set; }

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

    [Column("CERegnNo")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CeregnNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TarriffHeadingNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Range { get; set; }

    [Column("EDDivision")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Eddivision { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CommissionRate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NotificationValid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute4 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute5 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute6 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute7 { get; set; }

    [InverseProperty("BranchU")]
    public virtual ICollection<AreaM> AreaMs { get; set; } = new List<AreaM>();

    [InverseProperty("BranchU")]
    public virtual ICollection<BranchCreditNoteRegularApproval> BranchCreditNoteRegularApprovals { get; set; } = new List<BranchCreditNoteRegularApproval>();

    [InverseProperty("BranchU")]
    public virtual ICollection<BranchCreditNoteRegularRequest> BranchCreditNoteRegularRequests { get; set; } = new List<BranchCreditNoteRegularRequest>();

    [InverseProperty("BranchU")]
    public virtual ICollection<BranchDivisionLink> BranchDivisionLinks { get; set; } = new List<BranchDivisionLink>();

    [InverseProperty("BranchU")]
    public virtual ICollection<BranchImprest> BranchImprests { get; set; } = new List<BranchImprest>();

    [InverseProperty("BranchU")]
    public virtual ICollection<BranchItemRate> BranchItemRates { get; set; } = new List<BranchItemRate>();

    [InverseProperty("RequestedBranchU")]
    public virtual ICollection<ConsignmentHeader> ConsignmentHeaders { get; set; } = new List<ConsignmentHeader>();

    [InverseProperty("BranchU")]
    public virtual ICollection<DiscountMappingBranch> DiscountMappingBranches { get; set; } = new List<DiscountMappingBranch>();

    [InverseProperty("BranchU")]
    public virtual ICollection<DrCrCodeSelect> DrCrCodeSelects { get; set; } = new List<DrCrCodeSelect>();

    [InverseProperty("BranchU")]
    public virtual ICollection<EdchargesM> EdchargesMs { get; set; } = new List<EdchargesM>();

    [InverseProperty("BranchU")]
    public virtual ICollection<FreightChargesM> FreightChargesMs { get; set; } = new List<FreightChargesM>();

    [InverseProperty("BranchU")]
    public virtual ICollection<HsncodeM> HsncodeMs { get; set; } = new List<HsncodeM>();

    [InverseProperty("BranchU")]
    public virtual ICollection<InventoryServiceTran> InventoryServiceTrans { get; set; } = new List<InventoryServiceTran>();

    [InverseProperty("BranchU")]
    public virtual ICollection<InventoryTran> InventoryTrans { get; set; } = new List<InventoryTran>();

    [InverseProperty("BranchU")]
    public virtual ICollection<ItemM> ItemMs { get; set; } = new List<ItemM>();

    [InverseProperty("BranchU")]
    public virtual ICollection<PartyM> PartyMs { get; set; } = new List<PartyM>();

    [InverseProperty("RequestedBranchU")]
    public virtual ICollection<Poheader> Poheaders { get; set; } = new List<Poheader>();

    [InverseProperty("RequestedBranchU")]
    public virtual ICollection<Poindent> Poindents { get; set; } = new List<Poindent>();

    [InverseProperty("BranchU")]
    public virtual ICollection<PriceDiscountControlM> PriceDiscountControlMs { get; set; } = new List<PriceDiscountControlM>();

    [InverseProperty("BranchU")]
    public virtual ICollection<ProductionM> ProductionMs { get; set; } = new List<ProductionM>();

    [InverseProperty("BranchU")]
    public virtual ICollection<ProformaInvoiceHeader> ProformaInvoiceHeaders { get; set; } = new List<ProformaInvoiceHeader>();

    [InverseProperty("ReceivingBranchU")]
    public virtual ICollection<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; set; } = new List<PurchaseInvoiceHeader>();

    [InverseProperty("BranchU")]
    public virtual ICollection<SchemeGeneration> SchemeGenerations { get; set; } = new List<SchemeGeneration>();

    [InverseProperty("BranchU")]
    public virtual ICollection<StockPointCommisionM> StockPointCommisionMs { get; set; } = new List<StockPointCommisionM>();

    [InverseProperty("BranchU")]
    public virtual ICollection<StockPointDealerMapping> StockPointDealerMappings { get; set; } = new List<StockPointDealerMapping>();
}
