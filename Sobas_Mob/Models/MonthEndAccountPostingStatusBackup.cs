using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("MonthEndAccountPostingStatusBackup")]
public partial class MonthEndAccountPostingStatusBackup
{
    [Column("MonthEndAccountPostingStatusUID")]
    public Guid MonthEndAccountPostingStatusUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }
}
