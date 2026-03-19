using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempCreditNoteForDebitNotePreparation")]
public partial class TempCreditNoteForDebitNotePreparation
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

    [Column("PartyTypeUID")]
    public Guid PartyTypeUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string PartyCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column("TDSPer", TypeName = "decimal(18, 2)")]
    public decimal? Tdsper { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ConsCreditAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CalculatedAmt { get; set; }

    [Column("TDSPostingAmt", TypeName = "decimal(18, 3)")]
    public decimal TdspostingAmt { get; set; }

    [Column("TDSAmount", TypeName = "decimal(18, 3)")]
    public decimal Tdsamount { get; set; }

    [Column("ActualTDSAmount", TypeName = "decimal(18, 3)")]
    public decimal ActualTdsamount { get; set; }

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
