using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("OsAbove180")]
public partial class OsAbove180
{
    [StringLength(50)]
    [Unicode(false)]
    public string? StateCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? StateDesc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string SoName { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column("partyuid")]
    public Guid Partyuid { get; set; }

    [Column("divisionprincipleuid")]
    public Guid? Divisionprincipleuid { get; set; }

    [Column("O180D", TypeName = "decimal(38, 3)")]
    public decimal? O180d { get; set; }

    [Column("CAG", TypeName = "decimal(38, 3)")]
    public decimal? Cag { get; set; }

    [Column("COST", TypeName = "decimal(38, 3)")]
    public decimal? Cost { get; set; }

    [StringLength(8)]
    public string? MonName { get; set; }
}
