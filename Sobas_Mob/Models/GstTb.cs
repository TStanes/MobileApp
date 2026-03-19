using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("GstTb")]
public partial class GstTb
{
    public int AccountType { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string AccountTypeDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string AccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string AccountDescription { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ParentAccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? ParentAccountDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string OriginalAccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string OriginalAccountDescription { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string GroupCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string GroupDesc { get; set; } = null!;

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? OpbDebitAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? OpbCreditAmt { get; set; }

    public int DebitAmt { get; set; }

    public int CreditAmt { get; set; }

    [Column("branchcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Branchcode { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Info { get; set; } = null!;

    [StringLength(9)]
    [Unicode(false)]
    public string AcYear { get; set; } = null!;
}
