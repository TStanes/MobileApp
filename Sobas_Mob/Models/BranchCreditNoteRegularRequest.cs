using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("BranchCreditNoteRegularRequest")]
public partial class BranchCreditNoteRegularRequest
{
    [Key]
    [Column("BrCrNoteRegRequestUID")]
    public Guid BrCrNoteRegRequestUid { get; set; }

    public int? SlNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RequestNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("PurposeUID")]
    public Guid PurposeUid { get; set; }

    [Column("CreditAccountUID")]
    public Guid CreditAccountUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    public bool? IsProcessed { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? Coll1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Coll2 { get; set; }

    [Column("coll3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Coll3 { get; set; }

    [Column("ItemSegmentUID")]
    public Guid? ItemSegmentUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid? ItemGroupUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [Column("NewBranchUID")]
    public Guid? NewBranchUid { get; set; }

    [ForeignKey("BranchUid")]
    [InverseProperty("BranchCreditNoteRegularRequests")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("CreditAccountUid")]
    [InverseProperty("BranchCreditNoteRegularRequests")]
    public virtual AccountM CreditAccountU { get; set; } = null!;

    [ForeignKey("DivisionUid")]
    [InverseProperty("BranchCreditNoteRegularRequests")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [ForeignKey("PurposeUid")]
    [InverseProperty("BranchCreditNoteRegularRequests")]
    public virtual TransactionTypePurposeDetailM PurposeU { get; set; } = null!;
}
