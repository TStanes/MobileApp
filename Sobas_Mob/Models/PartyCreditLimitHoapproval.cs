using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PartyCreditLimitHOApproval")]
public partial class PartyCreditLimitHoapproval
{
    [Key]
    [Column("ApprovedPartyCreditLimitUID")]
    public Guid ApprovedPartyCreditLimitUid { get; set; }

    [Column("RequestPartyCreditLimitUID")]
    public Guid RequestPartyCreditLimitUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("PartyCreditLimitUID")]
    public Guid PartyCreditLimitUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(50)]
    public string ApprovalNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ApprovalDate { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal ApprovedCreditLimit { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal ApprovedCreditDays { get; set; }

    [Unicode(false)]
    public string RequestFor { get; set; } = null!;

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
