using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Temp")]
public partial class Temp
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
    public decimal? DebitAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? CreditAmt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LineBranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? LineBranchName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? LineDivision { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LineDivisionCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? LineState { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LineStateCode { get; set; }
}
