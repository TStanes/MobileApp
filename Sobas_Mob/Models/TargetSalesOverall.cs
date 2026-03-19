using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TargetSalesOverall")]
public partial class TargetSalesOverall
{
    [Column("PRODUCT")]
    [StringLength(255)]
    public string? Product { get; set; }

    [Column("YEAR TARGET", TypeName = "decimal(18, 2)")]
    public decimal? YearTarget { get; set; }

    [Column("CURRENT YEAR SALES", TypeName = "decimal(18, 2)")]
    public decimal? CurrentYearSales { get; set; }

    [Column("PREVIOUS YEAR SALES", TypeName = "decimal(18, 2)")]
    public decimal? PreviousYearSales { get; set; }

    [Column("INCREASE/DECREASE VALUE", TypeName = "decimal(18, 2)")]
    public decimal? IncreaseDecreaseValue { get; set; }

    [Column("INCREASE/DECREASE PERCENTAGE", TypeName = "decimal(18, 2)")]
    public decimal? IncreaseDecreasePercentage { get; set; }
}
