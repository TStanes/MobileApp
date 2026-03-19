using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TargetM")]
public partial class TargetM
{
    [Key]
    [Column("TargetUID")]
    public Guid TargetUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string TargetDescription { get; set; } = null!;

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

    [InverseProperty("TargetU")]
    public virtual ICollection<CommissionTargetLink> CommissionTargetLinks { get; set; } = new List<CommissionTargetLink>();

    [InverseProperty("TargetU")]
    public virtual ICollection<TargetItemLinkMapping> TargetItemLinkMappings { get; set; } = new List<TargetItemLinkMapping>();
}
