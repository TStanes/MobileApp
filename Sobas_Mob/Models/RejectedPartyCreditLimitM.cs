using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("RejectedPartyCreditLimitM")]
public partial class RejectedPartyCreditLimitM
{
    [Column("PartyCreditLimitUID")]
    public Guid PartyCreditLimitUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("FinancialYearUID")]
    public Guid FinancialYearUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyAcHead { get; set; }

    [Column("PartyGLCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyGlcode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RequestFor { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal CreditDays { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal CreditLimit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PreparedBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RecommendedBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Justification { get; set; }

    public bool BadDebts { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Reason { get; set; }

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
