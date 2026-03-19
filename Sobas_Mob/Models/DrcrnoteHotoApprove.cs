using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("DRCRNoteHOtoApprove")]
public partial class DrcrnoteHotoApprove
{
    [Key]
    [Column("DRCRNoteHOtoApproveUID")]
    public Guid DrcrnoteHotoApproveUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RequestNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [Column("TransactionTypePurposeTranUID")]
    public Guid TransactionTypePurposeTranUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Amount { get; set; }

    public bool TransferFlg { get; set; }

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
