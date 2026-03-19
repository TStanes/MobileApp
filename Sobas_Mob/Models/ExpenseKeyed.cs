using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ExpenseKeyed")]
public partial class ExpenseKeyed
{
    public double? BranchCode { get; set; }

    public double? DivisionCode { get; set; }

    public double? EmployeeCode { get; set; }

    [StringLength(255)]
    public string? EmployeeName { get; set; }

    [StringLength(255)]
    public string? EmployeePhone { get; set; }

    public double? Amount { get; set; }
}
