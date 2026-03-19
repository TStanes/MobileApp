using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DivisionM")]
public partial class DivisionM
{
    [Key]
    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Abbriviation { get; set; } = null!;

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

    [InverseProperty("DivisionU")]
    public virtual ICollection<BranchCreditNoteRegularApproval> BranchCreditNoteRegularApprovals { get; set; } = new List<BranchCreditNoteRegularApproval>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<BranchCreditNoteRegularRequest> BranchCreditNoteRegularRequests { get; set; } = new List<BranchCreditNoteRegularRequest>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<BranchDivisionLink> BranchDivisionLinks { get; set; } = new List<BranchDivisionLink>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<BranchImprest> BranchImprests { get; set; } = new List<BranchImprest>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<ConsignmentHeader> ConsignmentHeaders { get; set; } = new List<ConsignmentHeader>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<CreditDaysM> CreditDaysMs { get; set; } = new List<CreditDaysM>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<DiscountItemLink> DiscountItemLinks { get; set; } = new List<DiscountItemLink>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<DiscountM> DiscountMs { get; set; } = new List<DiscountM>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<DiscountPercentageallowed> DiscountPercentagealloweds { get; set; } = new List<DiscountPercentageallowed>();

    [InverseProperty("DivsionU")]
    public virtual ICollection<DivisionPrincipleM> DivisionPrincipleMs { get; set; } = new List<DivisionPrincipleM>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<DrCrCodeSelect> DrCrCodeSelects { get; set; } = new List<DrCrCodeSelect>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<InventoryServiceTran> InventoryServiceTrans { get; set; } = new List<InventoryServiceTran>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<InventoryTran> InventoryTrans { get; set; } = new List<InventoryTran>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<ItemDivisionLink> ItemDivisionLinks { get; set; } = new List<ItemDivisionLink>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<OverdueDaysM> OverdueDaysMs { get; set; } = new List<OverdueDaysM>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<PackM> PackMs { get; set; } = new List<PackM>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<PartyCreditLimitM> PartyCreditLimitMs { get; set; } = new List<PartyCreditLimitM>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<PartyM> PartyMs { get; set; } = new List<PartyM>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<Poheader> Poheaders { get; set; } = new List<Poheader>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<Poindent> Poindents { get; set; } = new List<Poindent>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<PriceDiscountControlM> PriceDiscountControlMs { get; set; } = new List<PriceDiscountControlM>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<PrincipleSerialNumber> PrincipleSerialNumbers { get; set; } = new List<PrincipleSerialNumber>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<ProformaInvoiceHeader> ProformaInvoiceHeaders { get; set; } = new List<ProformaInvoiceHeader>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<SchemeGeneration> SchemeGenerations { get; set; } = new List<SchemeGeneration>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<TaxM> TaxMs { get; set; } = new List<TaxM>();

    [InverseProperty("DivisionU")]
    public virtual ICollection<UserGroupDivisionMappingM> UserGroupDivisionMappingMs { get; set; } = new List<UserGroupDivisionMappingM>();
}
