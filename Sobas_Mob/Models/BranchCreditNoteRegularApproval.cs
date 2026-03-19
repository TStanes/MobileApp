using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("BranchCreditNoteRegularApproval")]
public partial class BranchCreditNoteRegularApproval
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

    [Column(TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

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

    [Column("ItemSegmentUID")]
    public Guid? ItemSegmentUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid? ItemGroupUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [ForeignKey("AccountUid")]
    [InverseProperty("BranchCreditNoteRegularApprovals")]
    public virtual AccountM? AccountU { get; set; }

    [ForeignKey("BranchUid")]
    [InverseProperty("BranchCreditNoteRegularApprovals")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("DivisionUid")]
    [InverseProperty("BranchCreditNoteRegularApprovals")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [ForeignKey("PurposeUid")]
    [InverseProperty("BranchCreditNoteRegularApprovals")]
    public virtual TransactionTypePurposeDetailM PurposeU { get; set; } = null!;
}
