using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SalaryPostingTemplate")]
public partial class SalaryPostingTemplate
{
    [Column("SalaryPostingTemplateUID")]
    public Guid SalaryPostingTemplateUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("InstantUID")]
    public Guid InstantUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    public DateOnly VoucherDate { get; set; }

    [StringLength(500)]
    public string PostingType { get; set; } = null!;

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
