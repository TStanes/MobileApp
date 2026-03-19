using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DRCRNoteHOApproved")]
public partial class DrcrnoteHoapproved
{
    [Key]
    [Column("DRCRNoteHOApprovedUID")]
    public Guid DrcrnoteHoapprovedUid { get; set; }

    [Column("DRCRHOtoApproveUID")]
    public Guid DrcrhotoApproveUid { get; set; }

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

    [Column("HOVoucherNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string HovoucherNo { get; set; } = null!;

    [Column("HOVoucherDate", TypeName = "datetime")]
    public DateTime HovoucherDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PrincipalCreditNoteNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrincipalCreditNoteDt { get; set; }

    [Column("HORefNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? HorefNo { get; set; }

    [Column("HORefDt", TypeName = "datetime")]
    public DateTime? HorefDt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Amount { get; set; }

    public bool IsApproved { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string RejectionReason { get; set; } = null!;

    public bool UpdatedFlg { get; set; }

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
