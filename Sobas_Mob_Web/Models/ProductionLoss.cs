using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ProductionLoss")]
public partial class ProductionLoss
{
    [Key]
    [Column("ProductionLossUID", TypeName = "decimal(18, 0)")]
    public decimal ProductionLossUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("GrowerUID")]
    public Guid? GrowerUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal InitialMoisture { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal FinalMoisture { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DryingLoss { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Lot { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProcessRejQty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ProcessRejPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProcessChaffQty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ProcessChaffPer { get; set; }

    [Column("ProcessIVLQty", TypeName = "decimal(18, 3)")]
    public decimal ProcessIvlqty { get; set; }

    [Column("ProcessIVLPer", TypeName = "decimal(18, 2)")]
    public decimal ProcessIvlper { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProcessSandQty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ProcessSandPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProcessStoneQty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ProcessPerLot { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ProcessQtyLot { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ProcessStonePer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal MoistureLoss { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal RoastedLoss { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PackingLoss { get; set; }

    [Column("ProductionLoss", TypeName = "decimal(18, 3)")]
    public decimal ProductionLoss1 { get; set; }

    public bool IsActive { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [Column("GRN_InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal? GrnInventoryTransUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DryingDate { get; set; }

    [ForeignKey("InventoryTransUid")]
    [InverseProperty("ProductionLosses")]
    public virtual InventoryTran InventoryTransU { get; set; } = null!;
}
