using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DepreciationM")]
[Index("FassetTransDetailUid", Name = "<FAsset>")]
[Index("FassetTransDetailUid", Name = "<Name of Missing Index, sysname,>")]
public partial class DepreciationM
{
    [Key]
    [Column("DepreciationUID")]
    public Guid DepreciationUid { get; set; }

    [Column("FAssetTransDetailUID")]
    public Guid FassetTransDetailUid { get; set; }

    [StringLength(50)]
    public string DepreciationGenerationNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DepreciationGenerationDate { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal OriginalCostValue { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal CurrentRunningValue { get; set; }

    public int CalculatedDays { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal PerMonthValue { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal DepreciationValue { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal SalesCostValue { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal BalanceValue { get; set; }

    public int Type { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

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
