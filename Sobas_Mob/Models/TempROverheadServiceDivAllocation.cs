using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TEMP_R_Overhead_ServiceDiv_Allocation")]
public partial class TempROverheadServiceDivAllocation
{
    [StringLength(255)]
    public string? AccountCode { get; set; }

    [StringLength(800)]
    public string? AccountDescription { get; set; }

    [StringLength(255)]
    public string? TranType { get; set; }

    [Column("Income_ExpensesType")]
    [StringLength(255)]
    public string? IncomeExpensesType { get; set; }

    [Column("OPD", TypeName = "decimal(12, 2)")]
    public decimal? Opd { get; set; }

    [Column("APD", TypeName = "decimal(12, 2)")]
    public decimal? Apd { get; set; }

    [Column("CIPD", TypeName = "decimal(12, 2)")]
    public decimal? Cipd { get; set; }

    [Column("EXPORTS", TypeName = "decimal(12, 2)")]
    public decimal? Exports { get; set; }

    [Column("AHD", TypeName = "decimal(12, 2)")]
    public decimal? Ahd { get; set; }

    [Column("AED", TypeName = "decimal(12, 2)")]
    public decimal? Aed { get; set; }

    [Column("TOTAL", TypeName = "decimal(12, 2)")]
    public decimal? Total { get; set; }
}
