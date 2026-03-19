using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TargetSalescum")]
public partial class TargetSalescum
{
    [StringLength(150)]
    [Unicode(false)]
    public string? StateDesc { get; set; }

    [StringLength(255)]
    public string? GroupDesc { get; set; }

    [StringLength(255)]
    public string? Grp { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? MonthCumTarget { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? CurrentMonthCumVal { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? PrevyrMonthCumVal { get; set; }
}
