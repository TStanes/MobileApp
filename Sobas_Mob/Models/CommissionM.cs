using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("CommissionM")]
public partial class CommissionM
{
    [Key]
    [Column("CommissionUID")]
    public Guid CommissionUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string CommissionDesc { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    public short CommissionFor { get; set; }

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

    [InverseProperty("CommissionU")]
    public virtual ICollection<CommissionMappingBranch> CommissionMappingBranches { get; set; } = new List<CommissionMappingBranch>();

    [InverseProperty("CommissionU")]
    public virtual ICollection<CommissionQtyLift> CommissionQtyLifts { get; set; } = new List<CommissionQtyLift>();

    [InverseProperty("CommissionU")]
    public virtual ICollection<CommissionTargetLink> CommissionTargetLinks { get; set; } = new List<CommissionTargetLink>();

    [InverseProperty("CommissionU")]
    public virtual ICollection<CommissionValueLift> CommissionValueLifts { get; set; } = new List<CommissionValueLift>();

    [ForeignKey("DivisionUid")]
    [InverseProperty("CommissionMs")]
    public virtual DivisionM DivisionU { get; set; } = null!;
}
