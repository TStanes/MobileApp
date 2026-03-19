using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class TempCrDay
{
    [StringLength(10)]
    public string? StateCode { get; set; }

    [StringLength(10)]
    public string? BranchCode { get; set; }

    [StringLength(10)]
    public string? FinancialYear { get; set; }

    [StringLength(10)]
    public string? DivisionCode { get; set; }

    [StringLength(100)]
    public string? DivisionDesc { get; set; }

    [StringLength(50)]
    public string? DivisionPrincipleName { get; set; }

    public int? Days { get; set; }
}
