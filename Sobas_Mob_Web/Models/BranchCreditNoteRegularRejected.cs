using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("BranchCreditNoteRegularRejected")]
public partial class BranchCreditNoteRegularRejected
{
    [Key]
    [Column("BrCrNoteRegApprovalUID")]
    public Guid BrCrNoteRegApprovalUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("VoucherDetailUID")]
    public Guid VoucherDetailUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [Column("PurposeUID")]
    public Guid PurposeUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RequestNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RequestDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Detail { get; set; } = null!;

    public int TransId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal LineNumber { get; set; }

    [Column("AccountUID")]
    public Guid? AccountUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string LineDetails { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    public long IsUpdated { get; set; }

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
