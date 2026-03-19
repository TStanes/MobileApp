using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ExpenseApprovalHierarchy")]
public partial class ExpenseApprovalHierarchy
{
    public double? StateCode { get; set; }

    [StringLength(255)]
    public string? BranchCode { get; set; }

    [StringLength(255)]
    public string? DivisionCode { get; set; }

    [StringLength(255)]
    public string? StaffCode { get; set; }

    [StringLength(255)]
    public string? StaffName { get; set; }

    [Column("SSOName")]
    [StringLength(255)]
    public string? Ssoname { get; set; }

    [Column("SSOStaffCode")]
    public double? SsostaffCode { get; set; }

    public double? SecondApplEmpCode { get; set; }

    [StringLength(255)]
    public string? SecondApplEmpName { get; set; }

    [StringLength(255)]
    public string? FinalApplUser1Code { get; set; }

    [StringLength(255)]
    public string? FinalApplUser1Name { get; set; }

    [StringLength(255)]
    public string? FinalApplUser2Code { get; set; }

    [StringLength(255)]
    public string? FinalApplUser2Name { get; set; }
}
