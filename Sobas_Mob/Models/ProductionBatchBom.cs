using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ProductionBatchBOM")]
[Index("DocDate", Name = "IX_ProductionBatchBOM_DocDate")]
[Index("RbatchNo", Name = "IX_Rbatch")]
[Index("RinventoryTransUid", Name = "IX_Rinv_IRate_ISqty")]
[Index("IinventoryTransListUid", Name = "IX_invTransListUID")]
public partial class ProductionBatchBom
{
    [Column("RInventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal RinventoryTransUid { get; set; }

    [Column("RInventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal RinventoryTransListUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column("IInventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal IinventoryTransUid { get; set; }

    [Column("IInventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal IinventoryTransListUid { get; set; }

    [Column("RBatchNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RbatchNo { get; set; }

    [Column("FGItemUID")]
    public Guid FgitemUid { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal ReceiptQty { get; set; }

    [Column("RRate", TypeName = "decimal(18, 5)")]
    public decimal? Rrate { get; set; }

    [Column("IBatchNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IbatchNo { get; set; }

    [Column("RMItemUID")]
    public Guid RmitemUid { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal IssueQty { get; set; }

    [Column("IRate", TypeName = "decimal(18, 5)")]
    public decimal? Irate { get; set; }

    [Column("CompositionStateUID")]
    public Guid? CompositionStateUid { get; set; }

    public bool? IsProcessed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdated { get; set; }
}
