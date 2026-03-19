using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("BceReimb")]
[Index("ReqStatementNo", Name = "IX_ReqStNo")]
public partial class BceReimb
{
    [Key]
    [Column("BceReimbUID")]
    public Guid BceReimbUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReqStatementNo { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal RequestedAmt { get; set; }

    [Column("DDNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Ddno { get; set; }

    [Column("DDDate", TypeName = "datetime")]
    public DateTime? Dddate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ReceivedAmt { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RecStatementNo { get; set; } = null!;

    public bool? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OpeningCashOnHand { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalExpenses { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CollectionCashUtilised { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CashOnHand { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ReimPendingAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("StartingVoucherUID")]
    public Guid? StartingVoucherUid { get; set; }

    [Column("EndingVoucherHeaderUID")]
    public Guid? EndingVoucherHeaderUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CashOnHandTillDate { get; set; }
}
