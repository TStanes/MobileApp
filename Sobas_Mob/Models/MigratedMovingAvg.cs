using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("MigratedMovingAvg")]
public partial class MigratedMovingAvg
{
    [Column("RowUID")]
    public Guid? RowUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string TransactionTypecode { get; set; } = null!;

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("IssueBranchUID")]
    public Guid IssueBranchUid { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal MovingAvg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;
}
