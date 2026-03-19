using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PartyCreditLimitBranchRequest")]
public partial class PartyCreditLimitBranchRequest
{
    [Key]
    [Column("RequestPartyCreditLimitUID")]
    public Guid RequestPartyCreditLimitUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("PartyCreditLimitUID")]
    public Guid PartyCreditLimitUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(50)]
    public string RequestNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal ReqCreditLimit { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal ReqCreditDays { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal ExpectedTurnOver { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal CurrentOrderValue { get; set; }

    [Column("RecommendedSOUID")]
    public Guid RecommendedSouid { get; set; }

    [Unicode(false)]
    public string RequestFor { get; set; } = null!;

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

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
