using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("CommissionTargetLink")]
public partial class CommissionTargetLink
{
    [Key]
    [Column("CommissionTargetLinkUID")]
    public Guid CommissionTargetLinkUid { get; set; }

    [Column("CommissionUID")]
    public Guid CommissionUid { get; set; }

    [Column("TargetUID")]
    public Guid TargetUid { get; set; }

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

    [ForeignKey("CommissionUid")]
    [InverseProperty("CommissionTargetLinks")]
    public virtual CommissionM CommissionU { get; set; } = null!;

    [ForeignKey("TargetUid")]
    [InverseProperty("CommissionTargetLinks")]
    public virtual TargetM TargetU { get; set; } = null!;
}
