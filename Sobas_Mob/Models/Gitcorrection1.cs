using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class Gitcorrection1
{
    [Column("GITAccountUID")]
    public Guid GitaccountUid { get; set; }

    [Column("INVAccountUID")]
    public Guid InvaccountUid { get; set; }

    [Column("GITAccount")]
    [StringLength(130)]
    [Unicode(false)]
    public string? Gitaccount { get; set; }

    [Column("GITAccountDescription")]
    [StringLength(800)]
    [Unicode(false)]
    public string GitaccountDescription { get; set; } = null!;

    [StringLength(130)]
    [Unicode(false)]
    public string InvAccount { get; set; } = null!;

    [Column("INVAccountDescription")]
    [StringLength(800)]
    [Unicode(false)]
    public string InvaccountDescription { get; set; } = null!;

    [Column(TypeName = "decimal(38, 8)")]
    public decimal? InvDr { get; set; }

    [Column("GITCr", TypeName = "decimal(38, 8)")]
    public decimal? Gitcr { get; set; }

    [Column("GITDr", TypeName = "decimal(38, 8)")]
    public decimal? Gitdr { get; set; }

    [Column(TypeName = "decimal(38, 8)")]
    public decimal? InvCr { get; set; }
}
