using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PartyM")]
[Index("PartyGlcode", Name = "IX_PartyGlCode")]
[Index("BranchUid", Name = "IX_PartyM_BranchUID_Includes")]
[Index("IsActive", Name = "IX_isActive_PartyUD")]
[Index("PartyTypeUid", "IsActive", Name = "IX_partyTypeISactive")]
[Index("PartyCode", Name = "IX_partycode_Add")]
[Index("PartyUid", Name = "_dta_index_PartyM_7_1234103437__K1_5_13_21_43")]
[Index("PartyUid", "PartyGlcode", Name = "_dta_index_PartyM_7_1234103437__K1_K13")]
[Index("PartyUid", "CountryUid", "PartyCode", "StatusUid", "StateUid", "PartyTitle", "PartyInitials", "PartyName", "Address1", "Address2", "Address3", "Address4", "City", Name = "_dta_index_PartyM_7_1234103437__K1_K21_K6_K43_K20_K7_K8_K9_K14_K15_K16_K17_K18_19")]
[Index("PartyUid", "PartyCode", "ExciseDivision", "PartyTypeUid", "PartyGlcode", "PartyName", Name = "_dta_index_PartyM_7_1234103437__K1_K6_K30_K2_K13_K9")]
[Index("ExciseDivision", "PartyTypeUid", "PartyUid", "PartyGlcode", "PartyCode", "PartyName", Name = "_dta_index_PartyM_7_1234103437__K30_K2_K1_K13_K6_K9")]
[Index("DivisionUid", "PartyName", "PartyUid", "CountryUid", "StatusUid", Name = "_dta_index_PartyM_7_1234103437__K5_K9_K1_K21_K43")]
[Index("PartyCode", "PartyUid", "PartyTypeUid", "ExciseDivision", "PartyGlcode", "PartyName", Name = "_dta_index_PartyM_7_1234103437__K6_K1_K2_K30_K13_K9")]
public partial class PartyM
{
    [Key]
    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("PartyTypeUID")]
    public Guid PartyTypeUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("AreaUID")]
    public Guid? AreaUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string PartyCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? PartyTitle { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PartyInitials { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column("DealerTypeUID")]
    public Guid? DealerTypeUid { get; set; }

    [Column("DealerCategoryUID")]
    public Guid? DealerCategoryUid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PartyAcHead { get; set; }

    [Column("PartyGLCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyGlcode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PinCode { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("CountryUID")]
    public Guid CountryUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TelephoneNo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? FaxNo { get; set; }

    [Column("TINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tinno { get; set; } = null!;

    [Column("LST")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Lst { get; set; }

    [Column("CST")]
    [StringLength(50)]
    [Unicode(false)]
    public string Cst { get; set; } = null!;

    [Column("PANNo")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Panno { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ExciseNo { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? ExciseOffice { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExciseDivision { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExciseRange { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? WebAddress { get; set; }

    public bool? VatCovered { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NatureOfBusiness { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FertLicenceNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PestLicenceNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContactPerson { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ContactPersonPhoneNo { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PartyRequestNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PartyRequestDate { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    public bool Legal { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RejectionReason { get; set; }

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

    [Column("GSTNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Gstno { get; set; } = null!;

    [ForeignKey("AreaUid")]
    [InverseProperty("PartyMs")]
    public virtual AreaM? AreaU { get; set; }

    [InverseProperty("PartyU")]
    public virtual ICollection<Bdlist> Bdlists { get; set; } = new List<Bdlist>();

    [ForeignKey("BranchUid")]
    [InverseProperty("PartyMs")]
    public virtual BranchM? BranchU { get; set; }

    [InverseProperty("SupplierU")]
    public virtual ICollection<ConsignmentHeader> ConsignmentHeaders { get; set; } = new List<ConsignmentHeader>();

    [ForeignKey("CountryUid")]
    [InverseProperty("PartyMs")]
    public virtual CountryM CountryU { get; set; } = null!;

    [InverseProperty("PartyU")]
    public virtual ICollection<DealerAsset> DealerAssets { get; set; } = new List<DealerAsset>();

    [InverseProperty("PartyU")]
    public virtual ICollection<DealerBankDetail> DealerBankDetails { get; set; } = new List<DealerBankDetail>();

    [ForeignKey("DealerCategoryUid")]
    [InverseProperty("PartyMs")]
    public virtual DealerCategoryM? DealerCategoryU { get; set; }

    [InverseProperty("PartyU")]
    public virtual ICollection<DealerDeposit> DealerDeposits { get; set; } = new List<DealerDeposit>();

    [InverseProperty("PartyU")]
    public virtual ICollection<DealerItemRate> DealerItemRates { get; set; } = new List<DealerItemRate>();

    [InverseProperty("PartyU")]
    public virtual ICollection<DiscountMappingDealer> DiscountMappingDealers { get; set; } = new List<DiscountMappingDealer>();

    [ForeignKey("DivisionUid")]
    [InverseProperty("PartyMs")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [InverseProperty("PartyU")]
    public virtual ICollection<FollowUpDetail> FollowUpDetails { get; set; } = new List<FollowUpDetail>();

    [InverseProperty("PartyU")]
    public virtual ICollection<InventoryServiceTran> InventoryServiceTrans { get; set; } = new List<InventoryServiceTran>();

    [InverseProperty("PartyU")]
    public virtual ICollection<InventoryTran> InventoryTrans { get; set; } = new List<InventoryTran>();

    [InverseProperty("PartyU")]
    public virtual ICollection<ItemInterested> ItemInteresteds { get; set; } = new List<ItemInterested>();

    [InverseProperty("PartyU")]
    public virtual ICollection<ItemSupplierLink> ItemSupplierLinks { get; set; } = new List<ItemSupplierLink>();

    [InverseProperty("PartyCodeNavigation")]
    public virtual JdaListM? JdaListM { get; set; }

    [InverseProperty("PartyU")]
    public virtual ICollection<PartyCreditLimitM> PartyCreditLimitMs { get; set; } = new List<PartyCreditLimitM>();

    [InverseProperty("PartyU")]
    public virtual ICollection<PartyShipTo> PartyShipTos { get; set; } = new List<PartyShipTo>();

    [ForeignKey("PartyTypeUid")]
    [InverseProperty("PartyMs")]
    public virtual PartyTypeM PartyTypeU { get; set; } = null!;

    [InverseProperty("SupplierU")]
    public virtual ICollection<Poheader> Poheaders { get; set; } = new List<Poheader>();

    [InverseProperty("PartyU")]
    public virtual ICollection<ProformaInvoiceHeader> ProformaInvoiceHeaders { get; set; } = new List<ProformaInvoiceHeader>();

    [InverseProperty("SupplierU")]
    public virtual ICollection<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; set; } = new List<PurchaseInvoiceHeader>();

    [ForeignKey("StateUid")]
    [InverseProperty("PartyMs")]
    public virtual StateM1 StateU { get; set; } = null!;

    [ForeignKey("StatusUid")]
    [InverseProperty("PartyMs")]
    public virtual StatusM StatusU { get; set; } = null!;

    [InverseProperty("PartyU")]
    public virtual ICollection<StockPointDealerMapping> StockPointDealerMappings { get; set; } = new List<StockPointDealerMapping>();

    [InverseProperty("CustomerU")]
    public virtual VendorMappingM? VendorMappingMCustomerU { get; set; }

    [InverseProperty("SupplierU")]
    public virtual VendorMappingM? VendorMappingMSupplierU { get; set; }
}
