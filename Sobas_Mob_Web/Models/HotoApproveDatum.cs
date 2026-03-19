using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("HOToApproveData")]
public partial class HotoApproveDatum
{
    [Key]
    [Column("HOToApproveDataGUID")]
    public Guid HotoApproveDataGuid { get; set; }

    [Column("HOToApproveDataUID", TypeName = "decimal(18, 0)")]
    public decimal HotoApproveDataUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RequestNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? RequestDt { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [Column("AreaSOUID")]
    public Guid? AreaSouid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    public bool TransferFlag { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    public bool UpdateFlg { get; set; }
}
