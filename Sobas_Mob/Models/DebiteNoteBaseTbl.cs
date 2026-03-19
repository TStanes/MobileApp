using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DebiteNoteBaseTbl")]
public partial class DebiteNoteBaseTbl
{
    [Column("GenerationNewUID")]
    public Guid GenerationNewUid { get; set; }

    [Column("DebiteNoteBaseUID")]
    public Guid DebiteNoteBaseUid { get; set; }

    [Column("VoucherUID")]
    public Guid VoucherUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? BalUnAdjAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AdjAmt { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? CreditDays { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Duedays { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? CrLimit { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? TotalCrLimit { get; set; }

    public bool? BadDebts { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherGenerationDt { get; set; }

    public int? WorkingCalculationDay { get; set; }

    public int? NoOfDays { get; set; }

    [Column("OSDays")]
    public int? Osdays { get; set; }

    public bool? IsProcess { get; set; }

    public bool? IsSend { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? InterestAmt { get; set; }

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
