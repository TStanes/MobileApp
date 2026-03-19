using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class PreRate
{
    [Column("InventoryTransListUID")]
    public double? InventoryTransListUid { get; set; }

    [Column("branchuid")]
    [StringLength(255)]
    public string? Branchuid { get; set; }

    [Column("ItemUID")]
    [StringLength(255)]
    public string? ItemUid { get; set; }

    public double? MovingAvg { get; set; }
}
