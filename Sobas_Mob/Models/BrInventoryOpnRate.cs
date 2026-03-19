using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("BR_Inventory_OPN_Rate")]
public partial class BrInventoryOpnRate
{
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(129)]
    [Unicode(false)]
    public string AccountCode { get; set; } = null!;

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? NewValue { get; set; }
}
