using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("POIndent")]
[Index("DivisionUid", "ItemUid", Name = "IX_DivisionUID_Itemuid")]
[Index("DivisionUid", "StatusUid", "RequestedBranchUid", "IndentNo", "IndentDate", Name = "IX_DivisionUID_StatusUID")]
public partial class Poindent
{
    [Key]
    [Column("POIndentUID", TypeName = "decimal(18, 0)")]
    public decimal PoindentUid { get; set; }

    [Column("RequestedBranchUID")]
    public Guid RequestedBranchUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string IndentNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IndentDate { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal StockInHand { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal PendingOrderQty { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal RequiredQty { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal OrderQty { get; set; }

    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal ApprovedQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RejectedDate { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    public bool TransferFlg { get; set; }

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

    [ForeignKey("DivisionUid")]
    [InverseProperty("Poindents")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [ForeignKey("ItemUid")]
    [InverseProperty("Poindents")]
    public virtual ItemM ItemU { get; set; } = null!;

    [ForeignKey("RequestedBranchUid")]
    [InverseProperty("Poindents")]
    public virtual BranchM RequestedBranchU { get; set; } = null!;
}
