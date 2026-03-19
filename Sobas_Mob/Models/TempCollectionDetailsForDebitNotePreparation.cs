using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempCollectionDetailsForDebitNotePreparation")]
public partial class TempCollectionDetailsForDebitNotePreparation
{
    [Column("GenerationNewUID")]
    public Guid GenerationNewUid { get; set; }

    [Column("DebitNoteGenMonthUID")]
    public Guid DebitNoteGenMonthUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DebitNoteGenDate { get; set; }

    [Column("FYear")]
    [StringLength(9)]
    [Unicode(false)]
    public string Fyear { get; set; } = null!;

    [StringLength(9)]
    [Unicode(false)]
    public string CurrentMonth { get; set; } = null!;

    [Column("PartyBranchUID")]
    public Guid PartyBranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string PartyCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ConsCredit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CurrentMonCredit { get; set; }

    [Column("TCSCalAmount", TypeName = "decimal(18, 3)")]
    public decimal TcscalAmount { get; set; }

    [Column("TCSPostingAmount", TypeName = "decimal(18, 3)")]
    public decimal TcspostingAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal April { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal May { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal June { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal July { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal August { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal September { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal October { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal November { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal December { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal January { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal February { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal March { get; set; }

    public bool IsProcess { get; set; }

    public bool IsSend { get; set; }

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
