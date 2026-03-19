using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("branchDivisionLinkBackup")]
public partial class BranchDivisionLinkBackup
{
    [Column("BranchDivisionLinkUID")]
    public Guid BranchDivisionLinkUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("SundryDebtorsUID")]
    public Guid? SundryDebtorsUid { get; set; }

    [Column("SundryCreditorsUID")]
    public Guid? SundryCreditorsUid { get; set; }

    [Column("DealerDepositUID")]
    public Guid? DealerDepositUid { get; set; }

    [Column("ImprestCodeUID")]
    public Guid? ImprestCodeUid { get; set; }

    [Column("SpecialImprestCodeUID")]
    public Guid? SpecialImprestCodeUid { get; set; }

    [Column("PostageImprestUID")]
    public Guid? PostageImprestUid { get; set; }

    [Column("SOSImprestUID")]
    public Guid? SosimprestUid { get; set; }

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
