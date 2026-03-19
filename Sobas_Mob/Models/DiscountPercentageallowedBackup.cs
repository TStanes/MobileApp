using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DiscountPercentageallowedBackup")]
public partial class DiscountPercentageallowedBackup
{
    [Column("DiscountPercentageallowedUID")]
    public Guid DiscountPercentageallowedUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Percentage { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Createdby { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount3Percentage { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal AdvDiscount4Percentage { get; set; }
}
