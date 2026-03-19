using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SowingReportM")]
public partial class SowingReportM
{
    [Key]
    [Column("SowingReportUID")]
    public Guid SowingReportUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(20)]
    public string SowingReportNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SowingReportDate { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("SCNo")]
    [StringLength(20)]
    public string Scno { get; set; } = null!;

    [Column("SCDate", TypeName = "datetime")]
    public DateTime Scdate { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [StringLength(50)]
    public string Crop { get; set; } = null!;

    [Column("SeedVarietyUID")]
    public Guid SeedVarietyUid { get; set; }

    [Column("SeedTypeUID")]
    public Guid SeedTypeUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Acres { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateofSowing { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateofTransplantation { get; set; }

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
