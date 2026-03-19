using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("CommissionMappingBranch")]
public partial class CommissionMappingBranch
{
    [Key]
    [Column("CommissionMappingBranchUID")]
    public Guid CommissionMappingBranchUid { get; set; }

    [Column("CommissionUID")]
    public Guid CommissionUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

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

    [ForeignKey("BranchUid")]
    [InverseProperty("CommissionMappingBranches")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("CommissionUid")]
    [InverseProperty("CommissionMappingBranches")]
    public virtual CommissionM CommissionU { get; set; } = null!;
}
