using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Mis_RecosData")]
public partial class MisRecosDatum
{
    [Column("branchcode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Branchcode { get; set; } = null!;

    [Column("branchname")]
    [StringLength(150)]
    [Unicode(false)]
    public string Branchname { get; set; } = null!;

    [Column("partycode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Partycode { get; set; }

    [Column("partyname")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partyname { get; set; } = null!;

    [Column("statedesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Statedesc { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? DivisionName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SoCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SoName { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? OutstandingAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Over180Days { get; set; }

    [Column("CAG", TypeName = "decimal(38, 3)")]
    public decimal? Cag { get; set; }
}
