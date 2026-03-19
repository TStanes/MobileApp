using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("AccountM")]
public partial class AccountM
{
    [Key]
    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string AccountDescription { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string PrintDescription { get; set; } = null!;

    public int AccountType { get; set; }

    public bool IsGroup { get; set; }

    public bool? IsDivision { get; set; }

    [StringLength(10)]
    public string? IsBranch { get; set; }

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

    [InverseProperty("UnderAccountU")]
    public virtual ICollection<AccountGroupM> AccountGroupMs { get; set; } = new List<AccountGroupM>();

    [InverseProperty("AccountU")]
    public virtual ICollection<BranchCreditNoteRegularApproval> BranchCreditNoteRegularApprovals { get; set; } = new List<BranchCreditNoteRegularApproval>();

    [InverseProperty("CreditAccountU")]
    public virtual ICollection<BranchCreditNoteRegularRequest> BranchCreditNoteRegularRequests { get; set; } = new List<BranchCreditNoteRegularRequest>();

    [InverseProperty("DealerDepositU")]
    public virtual ICollection<BranchDivisionLink> BranchDivisionLinkDealerDepositUs { get; set; } = new List<BranchDivisionLink>();

    [InverseProperty("ImprestCodeU")]
    public virtual ICollection<BranchDivisionLink> BranchDivisionLinkImprestCodeUs { get; set; } = new List<BranchDivisionLink>();

    [InverseProperty("PostageImprestU")]
    public virtual ICollection<BranchDivisionLink> BranchDivisionLinkPostageImprestUs { get; set; } = new List<BranchDivisionLink>();

    [InverseProperty("SosimprestU")]
    public virtual ICollection<BranchDivisionLink> BranchDivisionLinkSosimprestUs { get; set; } = new List<BranchDivisionLink>();

    [InverseProperty("SpecialImprestCodeU")]
    public virtual ICollection<BranchDivisionLink> BranchDivisionLinkSpecialImprestCodeUs { get; set; } = new List<BranchDivisionLink>();

    [InverseProperty("SundryCreditorsU")]
    public virtual ICollection<BranchDivisionLink> BranchDivisionLinkSundryCreditorsUs { get; set; } = new List<BranchDivisionLink>();

    [InverseProperty("SundryDebtorsU")]
    public virtual ICollection<BranchDivisionLink> BranchDivisionLinkSundryDebtorsUs { get; set; } = new List<BranchDivisionLink>();

    [InverseProperty("AccountU")]
    public virtual ICollection<HsnaccountMappingM> HsnaccountMappingMs { get; set; } = new List<HsnaccountMappingM>();

    [InverseProperty("AccountU")]
    public virtual ICollection<StockPointCommisionAccountMapping> StockPointCommisionAccountMappings { get; set; } = new List<StockPointCommisionAccountMapping>();

    [InverseProperty("AccountU")]
    public virtual ICollection<StockPointCommissionDetail> StockPointCommissionDetails { get; set; } = new List<StockPointCommissionDetail>();

    [InverseProperty("AccountU")]
    public virtual ICollection<VoucherDetail> VoucherDetails { get; set; } = new List<VoucherDetail>();
}
