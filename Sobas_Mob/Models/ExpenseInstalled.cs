using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ExpenseInstalled")]
public partial class ExpenseInstalled
{
    public double? StaffCode { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    public double? Phone { get; set; }

    [StringLength(255)]
    public string? AppVersion { get; set; }
}
