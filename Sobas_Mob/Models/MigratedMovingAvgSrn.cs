using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("MigratedMovingAvg_SRN")]
public partial class MigratedMovingAvgSrn
{
    [Column("RowUID")]
    public Guid? RowUid { get; set; }

    [Column("InventoryTransUID", TypeName = "numeric(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string TransactionTypecode { get; set; } = null!;

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("IssueBranchUID")]
    public Guid IssueBranchUid { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal MovingAvg { get; set; }
}
