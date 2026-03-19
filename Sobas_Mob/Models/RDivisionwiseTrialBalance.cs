using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("R_DivisionwiseTrialBalance")]
public partial class RDivisionwiseTrialBalance
{
    public int? Slno { get; set; }

    public int? AccountType { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? AccountTypeDesc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? AccountDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ParentAccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? ParentAccountDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OriginalAccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? OriginalAccountDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GroupCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? GroupDesc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DivisionCode { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? DebitAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? CreditAmt { get; set; }

    public int? VoucherYear { get; set; }

    public int? VoucherMonth { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? VoucherMonthName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherMonthStartDate { get; set; }
}
