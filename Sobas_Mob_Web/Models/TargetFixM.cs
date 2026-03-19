using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("TargetFixM")]
public partial class TargetFixM
{
    [Key]
    [Column("TargetFixMUID")]
    public Guid TargetFixMuid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("FYear")]
    [StringLength(9)]
    [Unicode(false)]
    public string Fyear { get; set; } = null!;

    [Column("SOUID")]
    public Guid Souid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("TargetUID")]
    public Guid TargetUid { get; set; }

    [StringLength(50)]
    public string TargetMappingType { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TargetTotalQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TargetTotalValue { get; set; }

    [Column("NR", TypeName = "decimal(18, 3)")]
    public decimal Nr { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal April { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal May { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal June { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal July { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal August { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal September { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal October { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal November { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal December { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal January { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal February { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal March { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
