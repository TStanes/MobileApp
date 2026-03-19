using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("expenseskeyed")]
public partial class Expenseskeyed
{
    public double? BranchCode { get; set; }

    public double? DivisionCode { get; set; }

    public double? EmployeeCode { get; set; }

    [StringLength(255)]
    public string? EmployeeName { get; set; }
}
