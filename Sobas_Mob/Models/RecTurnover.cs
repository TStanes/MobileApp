using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("RecTurnover")]
public partial class RecTurnover
{
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Column("branchname")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Branchname { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionAbbriviation { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? SoCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SoName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string AreaDesc { get; set; } = null!;

    public Guid Partyuid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? SalesVal { get; set; }

    [Column("finyear")]
    [StringLength(9)]
    [Unicode(false)]
    public string? Finyear { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PrincipleName { get; set; } = null!;
}
