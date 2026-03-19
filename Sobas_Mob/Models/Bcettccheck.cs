using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class Bcettccheck
{
    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionTypeCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? TransactionTypeDesc { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Purpose { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DrAccountCode { get; set; }

    [Column("DRAccountDescription")]
    [StringLength(800)]
    [Unicode(false)]
    public string? DraccountDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CrAccountCode { get; set; }

    [Column("CRAccountDescription")]
    [StringLength(800)]
    [Unicode(false)]
    public string? CraccountDescription { get; set; }
}
