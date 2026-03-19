using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("InOutRegisterMF_New")]
public partial class InOutRegisterMfNew
{
    [Key]
    [Column("RowUID")]
    public Guid RowUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? RefNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefDate { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string TransactionType { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string TransactionTypeDesc { get; set; } = null!;

    [Column("ItemCategoryUID")]
    public Guid ItemCategoryUid { get; set; }

    [Column("ItemSegmentUID")]
    public Guid ItemSegmentUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(60)]
    public string BatchNo { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Rate { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? MovingAvg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdated { get; set; }

    [Column("RateDerivedUID")]
    public int? RateDerivedUid { get; set; }

    [Column("CompositionStateUID")]
    public Guid? CompositionStateUid { get; set; }

    [Column("SNo")]
    public long Sno { get; set; }

    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("MAvgExemption", TypeName = "decimal(18, 5)")]
    public decimal? MavgExemption { get; set; }

    [Column("MAvgExemptionPercentage", TypeName = "decimal(18, 2)")]
    public decimal? MavgExemptionPercentage { get; set; }

    [Column("PreviousMAvg", TypeName = "decimal(18, 5)")]
    public decimal? PreviousMavg { get; set; }

    [Column("OpenMAvg", TypeName = "decimal(18, 5)")]
    public decimal? OpenMavg { get; set; }

    public bool? IsIssuedMore { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? QtyIssuedMore { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RunningStock { get; set; }

    public int StockMonth { get; set; }

    public int StockYear { get; set; }

    [Column("StockAdjPurposeMUID")]
    public Guid? StockAdjPurposeMuid { get; set; }

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
