using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PartyBankDetailsHOApproval")]
public partial class PartyBankDetailsHoapproval
{
    [Key]
    [Column("ApprovedPartyBankDetailUID")]
    public Guid ApprovedPartyBankDetailUid { get; set; }

    [Column("RequestPartyBankDetailUID")]
    public Guid RequestPartyBankDetailUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(50)]
    public string ApprovalNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ApprovalDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BankName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string BankLocation { get; set; } = null!;

    [Column("ACType")]
    [StringLength(50)]
    [Unicode(false)]
    public string Actype { get; set; } = null!;

    [Column("ACNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string Acnumber { get; set; } = null!;

    [Column("IFSCCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Ifsccode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string InpaymentOf { get; set; } = null!;

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [Unicode(false)]
    public string RejectionReason { get; set; } = null!;

    [Unicode(false)]
    public string Remarks { get; set; } = null!;

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
}
