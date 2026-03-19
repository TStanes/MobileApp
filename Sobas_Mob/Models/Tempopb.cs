using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Tempopb")]
public partial class Tempopb
{
    [Column("BRANCHUID")]
    public Guid Branchuid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [Column("RATE")]
    public int Rate { get; set; }
}
