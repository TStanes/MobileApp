using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ReportDataStateM")]
public partial class ReportDataStateM
{
    [Column("branchcode")]
    [StringLength(255)]
    public string? Branchcode { get; set; }

    [Column("branchName")]
    [StringLength(255)]
    public string? BranchName { get; set; }

    [StringLength(255)]
    public string? StateCode { get; set; }

    [StringLength(255)]
    public string? StateDesc { get; set; }

    [StringLength(255)]
    public string? DivisionDesc { get; set; }

    public double? ParentBranchCode { get; set; }

    [StringLength(255)]
    public string? ParentBranchName { get; set; }

    [StringLength(255)]
    public string? ReportState { get; set; }

    [StringLength(255)]
    public string? ReportDivision { get; set; }
}
