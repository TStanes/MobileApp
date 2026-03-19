using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TblEmployeeYearlyTargetInput")]
public partial class TblEmployeeYearlyTargetInput
{
    [StringLength(50)]
    public string? EmpCode { get; set; }

    [StringLength(50)]
    public string? Year { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [Column("Monthly_Target", TypeName = "decimal(18, 5)")]
    public decimal? MonthlyTarget { get; set; }
}
