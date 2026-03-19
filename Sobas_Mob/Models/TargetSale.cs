using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class TargetSale
{
    [StringLength(150)]
    [Unicode(false)]
    public string? StateDesc { get; set; }

    [StringLength(255)]
    public string? GroupDesc { get; set; }

    [StringLength(255)]
    public string? Grp { get; set; }

    public double? MonthTarget { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? CurrentMonthVal { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? PrevyrMonthVal { get; set; }
}
