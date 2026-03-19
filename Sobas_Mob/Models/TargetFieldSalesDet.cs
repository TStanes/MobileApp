using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TargetFieldSalesDet")]
public partial class TargetFieldSalesDet
{
    [StringLength(255)]
    public string? FinancialGroup { get; set; }

    [StringLength(255)]
    public string? SegmentGroup { get; set; }

    public double? YrTarget { get; set; }

    [Column("monthtarget")]
    public double? Monthtarget { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? CurMonSale { get; set; }

    public double? AchievementPer { get; set; }

    [Column("monthcumtarget")]
    public double? Monthcumtarget { get; set; }

    [Column("curyrsale", TypeName = "decimal(38, 6)")]
    public decimal? Curyrsale { get; set; }

    public double? CumAchievementPer { get; set; }

    [Column("prevYrSale", TypeName = "decimal(38, 6)")]
    public decimal? PrevYrSale { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? IncreaseInVal { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? IncreaseInPer { get; set; }
}
