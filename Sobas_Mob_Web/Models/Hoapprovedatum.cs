using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("HOApprovedata")]
public partial class Hoapprovedatum
{
    [Key]
    [Column("HOApproveDataGUID")]
    public Guid HoapproveDataGuid { get; set; }

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

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Qty { get; set; }

    public bool ApproveFlg { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string RejectReason { get; set; } = null!;

    public bool UpdateFlg { get; set; }

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
