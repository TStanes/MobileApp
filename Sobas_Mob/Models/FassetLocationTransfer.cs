using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FAssetLocationTransfer")]
public partial class FassetLocationTransfer
{
    [Key]
    [Column("FAssetLocationTransferUID")]
    public Guid FassetLocationTransferUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EntryDate { get; set; }

    [Column("FAssetTransDetailUID")]
    public Guid FassetTransDetailUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column("TransferBranchUID")]
    public Guid TransferBranchUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransferDate { get; set; }

    [StringLength(500)]
    public string Remarks { get; set; } = null!;

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
