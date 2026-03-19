using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("RollingForeCastM")]
public partial class RollingForeCastM
{
    [Key]
    [Column("RollingForeCastMUID")]
    public Guid RollingForeCastMuid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("FYear")]
    [StringLength(9)]
    [Unicode(false)]
    public string Fyear { get; set; } = null!;

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("April_F", TypeName = "decimal(18, 3)")]
    public decimal AprilF { get; set; }

    [Column("April_S", TypeName = "decimal(18, 3)")]
    public decimal AprilS { get; set; }

    [Column("April_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal AprilApprovedQty { get; set; }

    [Column("May_F", TypeName = "decimal(18, 3)")]
    public decimal MayF { get; set; }

    [Column("May_S", TypeName = "decimal(18, 3)")]
    public decimal MayS { get; set; }

    [Column("May_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal MayApprovedQty { get; set; }

    [Column("June_F", TypeName = "decimal(18, 3)")]
    public decimal JuneF { get; set; }

    [Column("June_S", TypeName = "decimal(18, 3)")]
    public decimal JuneS { get; set; }

    [Column("June_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal JuneApprovedQty { get; set; }

    [Column("July_F", TypeName = "decimal(18, 3)")]
    public decimal JulyF { get; set; }

    [Column("July_S", TypeName = "decimal(18, 3)")]
    public decimal JulyS { get; set; }

    [Column("July_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal JulyApprovedQty { get; set; }

    [Column("August_F", TypeName = "decimal(18, 3)")]
    public decimal AugustF { get; set; }

    [Column("August_S", TypeName = "decimal(18, 3)")]
    public decimal AugustS { get; set; }

    [Column("August_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal AugustApprovedQty { get; set; }

    [Column("September_F", TypeName = "decimal(18, 3)")]
    public decimal SeptemberF { get; set; }

    [Column("September_S", TypeName = "decimal(18, 3)")]
    public decimal SeptemberS { get; set; }

    [Column("September_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal SeptemberApprovedQty { get; set; }

    [Column("October_F", TypeName = "decimal(18, 3)")]
    public decimal OctoberF { get; set; }

    [Column("October_S", TypeName = "decimal(18, 3)")]
    public decimal OctoberS { get; set; }

    [Column("October_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal OctoberApprovedQty { get; set; }

    [Column("November_F", TypeName = "decimal(18, 3)")]
    public decimal NovemberF { get; set; }

    [Column("November_S", TypeName = "decimal(18, 3)")]
    public decimal NovemberS { get; set; }

    [Column("November_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal NovemberApprovedQty { get; set; }

    [Column("December_F", TypeName = "decimal(18, 3)")]
    public decimal DecemberF { get; set; }

    [Column("December_S", TypeName = "decimal(18, 3)")]
    public decimal DecemberS { get; set; }

    [Column("December_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal DecemberApprovedQty { get; set; }

    [Column("January_F", TypeName = "decimal(18, 3)")]
    public decimal JanuaryF { get; set; }

    [Column("January_S", TypeName = "decimal(18, 3)")]
    public decimal JanuaryS { get; set; }

    [Column("January_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal JanuaryApprovedQty { get; set; }

    [Column("February_F", TypeName = "decimal(18, 3)")]
    public decimal FebruaryF { get; set; }

    [Column("February_S", TypeName = "decimal(18, 3)")]
    public decimal FebruaryS { get; set; }

    [Column("February_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal FebruaryApprovedQty { get; set; }

    [Column("March_F", TypeName = "decimal(18, 3)")]
    public decimal MarchF { get; set; }

    [Column("March_S", TypeName = "decimal(18, 3)")]
    public decimal MarchS { get; set; }

    [Column("March_ApprovedQty", TypeName = "decimal(18, 3)")]
    public decimal MarchApprovedQty { get; set; }

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
