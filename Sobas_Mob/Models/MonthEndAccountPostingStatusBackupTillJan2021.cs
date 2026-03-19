using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("MonthEndAccountPostingStatusBackupTillJan2021")]
public partial class MonthEndAccountPostingStatusBackupTillJan2021
{
    [Column("MonthEndAccountPostingStatusUID")]
    public Guid MonthEndAccountPostingStatusUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }
}
