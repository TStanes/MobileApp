using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TargetSowiseSalesDet")]
public partial class TargetSowiseSalesDet
{
    [StringLength(255)]
    public string? SegmentGroup { get; set; }

    [StringLength(255)]
    public string? SegGrp { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? HeadName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? OverallHdName { get; set; }

    [Column("SOName")]
    [StringLength(150)]
    [Unicode(false)]
    public string Soname { get; set; } = null!;

    [Column("branchstatedesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Branchstatedesc { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    public double? CurMonthTarget { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? CurMonSale { get; set; }

    public double? CurMonAchieve { get; set; }

    public double? CumMonTarget { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? CumCurSale { get; set; }

    public double? CumTargetAchiev { get; set; }

    public double? TotTarget { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? TotAchievment { get; set; }

    public double? AchievmentPer { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? PpaExp { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? TaExp { get; set; }

    [Column("NoOfPPA")]
    public int? NoOfPpa { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? TotalOs { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? Over180Days { get; set; }
}
