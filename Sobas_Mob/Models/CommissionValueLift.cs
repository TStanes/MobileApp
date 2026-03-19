using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("CommissionValueLift")]
public partial class CommissionValueLift
{
    [Key]
    [Column("CommissionValueLiftUID")]
    public Guid CommissionValueLiftUid { get; set; }

    [Column("CommissionUID")]
    public Guid CommissionUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal FromValue { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ToValue { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Percentage { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Value { get; set; }

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
    [InverseProperty("CommissionValueLifts")]
    public virtual CommissionM CommissionU { get; set; } = null!;
}
