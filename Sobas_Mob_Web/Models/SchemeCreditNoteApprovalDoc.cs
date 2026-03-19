using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SchemeCreditNoteApprovalDoc")]
public partial class SchemeCreditNoteApprovalDoc
{
    [Key]
    [Column("SchemeCreditNoteApprovalDocUID")]
    public Guid SchemeCreditNoteApprovalDocUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ApprovedAmount { get; set; }

    public bool? IsApproved { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApprovedBy { get; set; }

    public bool? IsRejected { get; set; }

    [StringLength(2000)]
    public string? RejectionReason { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Createdby { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Modifiedby { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
