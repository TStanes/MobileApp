using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FAssetTransDetailExtn")]
public partial class FassetTransDetailExtn
{
    [Key]
    [Column("FAssetTransDetailUID")]
    public Guid FassetTransDetailUid { get; set; }

    public int TotalLifeTimeDays { get; set; }

    public int BalanceDays { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PurchaseQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SalesQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal BalanceQty { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? OpeningValue { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? OpeningAccumulatedDepreciationValue { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal OriginalCostValue { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal PerQtyCost { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal PerDayValue { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal BalanceValue { get; set; }

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

    [ForeignKey("FassetTransDetailUid")]
    [InverseProperty("FassetTransDetailExtn")]
    public virtual FassetTransDetail FassetTransDetailU { get; set; } = null!;
}
