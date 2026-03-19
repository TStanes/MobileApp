using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("MonthEndAccountPostingStatus")]
[Index("InventoryTransUid", Name = "IX_InventorytransUID_MonthEndStatusUID")]
public partial class MonthEndAccountPostingStatus
{
    [Key]
    [Column("MonthEndAccountPostingStatusUID")]
    public Guid MonthEndAccountPostingStatusUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }
}
