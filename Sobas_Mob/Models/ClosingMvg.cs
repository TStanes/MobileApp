using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ClosingMVG")]
public partial class ClosingMvg
{
    [Column("StateuID")]
    public Guid? StateuId { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("ItemUID")]
    public Guid? ItemUid { get; set; }

    [Column("ItemCategoryUID")]
    public Guid? ItemCategoryUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid? ItemGroupUid { get; set; }

    [Column("ClosingMVG", TypeName = "decimal(18, 5)")]
    public decimal? ClosingMvg1 { get; set; }
}
