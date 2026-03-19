using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class Ttccheck
{
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [Column("divisionUid")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string TransactionTypeDesc { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Purpose { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? DrAccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? DrAccountDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CrAccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? CrAccountDescription { get; set; }
}
