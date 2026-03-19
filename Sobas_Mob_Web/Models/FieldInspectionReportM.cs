using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("FieldInspectionReportM")]
public partial class FieldInspectionReportM
{
    [Key]
    [Column("FieldInspectionReportUID")]
    public Guid FieldInspectionReportUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("SowingReportUID")]
    public Guid SowingReportUid { get; set; }

    [StringLength(20)]
    public string FieldInspectionReportNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FieldInspectionReportDate { get; set; }

    [StringLength(20)]
    public string FieldInspectionNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FieldInspectionDate { get; set; }

    [StringLength(50)]
    public string? CropStage { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? NoofOffTypes { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PerofOffType { get; set; }

    [StringLength(50)]
    public string? Result { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
