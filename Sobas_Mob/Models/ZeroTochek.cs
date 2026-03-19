using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ZeroTochek")]
public partial class ZeroTochek
{
    [StringLength(255)]
    public string? ItemCategoryDesc { get; set; }

    [Column("CODE")]
    [StringLength(255)]
    public string? Code { get; set; }

    [StringLength(255)]
    public string? Branchname { get; set; }

    public double? Divisioncode { get; set; }

    [StringLength(255)]
    public string? DivisionDesc { get; set; }

    [StringLength(255)]
    public string? ItemCode { get; set; }

    [StringLength(255)]
    public string? ItemDesc { get; set; }

    [StringLength(255)]
    public string? ItemSegmentDesc { get; set; }

    [StringLength(255)]
    public string? ItemGroupDesc { get; set; }

    [StringLength(255)]
    public string? ItemSubGroupDesc { get; set; }

    public double? ClosingStock { get; set; }

    [Column("movingavg")]
    public double? Movingavg { get; set; }

    public double? Ed { get; set; }

    public double? Cess { get; set; }

    public double? Process { get; set; }

    [Column("frt")]
    public double? Frt { get; set; }

    public double? FinalRate { get; set; }

    public double? FinalValue { get; set; }

    [StringLength(255)]
    public string? Field19 { get; set; }

    [Column("FREIGHT CHARGES")]
    [StringLength(255)]
    public string? FreightCharges { get; set; }

    [Column("PROCESSING")]
    [StringLength(255)]
    public string? Processing { get; set; }

    [StringLength(255)]
    public string? Field22 { get; set; }
}
