using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConSalesOsColl")]
public partial class ConSalesOsColl
{
    public DateOnly? Date { get; set; }

    [Column("Branch code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Column("Branch Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [Column("Division Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [Column("Division Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string DivisionName { get; set; } = null!;

    [Column("Staff Code")]
    public int? StaffCode { get; set; }

    [Column("Staff Name")]
    [StringLength(200)]
    public string? StaffName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemSegmentCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemSegmentName { get; set; }

    [Column("Total Outstanding YTD")]
    public int? TotalOutstandingYtd { get; set; }

    [Column("Total Cost YTD")]
    public int? TotalCostYtd { get; set; }

    [Column("CGA YTD")]
    public int? CgaYtd { get; set; }

    [Column("GT 180 YTD")]
    public int? Gt180Ytd { get; set; }

    [Column("Collection Target YTD")]
    public int? CollectionTargetYtd { get; set; }

    [Column("Collection Actual YTD")]
    public int? CollectionActualYtd { get; set; }

    [Column("Sales Target YTD", TypeName = "decimal(18, 3)")]
    public decimal? SalesTargetYtd { get; set; }

    [Column("Sales Actual YTD", TypeName = "decimal(18, 3)")]
    public decimal? SalesActualYtd { get; set; }

    public bool? IsActive { get; set; }
}
