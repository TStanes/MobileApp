using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TargetSoBrSt")]
public partial class TargetSoBrSt
{
    [StringLength(255)]
    public string? TargetDescription { get; set; }

    [StringLength(255)]
    public string? GroupDesc { get; set; }

    [StringLength(255)]
    public string? SegmentGroup { get; set; }

    [StringLength(255)]
    public string? DivisionCode { get; set; }

    [StringLength(255)]
    public string? FinancialGroup { get; set; }

    public double? StateCode { get; set; }

    [StringLength(255)]
    public string? StateDesc { get; set; }

    public double? BranchCode { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    public double? EmpCode { get; set; }

    [Column("socode")]
    [StringLength(255)]
    public string? Socode { get; set; }

    [Column("soname")]
    [StringLength(255)]
    public string? Soname { get; set; }

    public double? TotalVal { get; set; }

    public double? AprVal { get; set; }

    public double? MayVal { get; set; }

    public double? JunVal { get; set; }

    public double? JulVal { get; set; }

    public double? AugVal { get; set; }

    public double? SepVal { get; set; }

    public double? OctVal { get; set; }

    public double? NovVal { get; set; }

    public double? DecVal { get; set; }

    public double? JanVal { get; set; }

    public double? FebVal { get; set; }

    public double? MarVal { get; set; }
}
