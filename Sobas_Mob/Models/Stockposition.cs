using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("stockposition")]
public partial class Stockposition
{
    [StringLength(10)]
    [Unicode(false)]
    public string? Divisioncode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DivisionDesc { get; set; }

    [Column("itemuid")]
    public Guid Itemuid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column("BAL", TypeName = "decimal(38, 5)")]
    public decimal? Bal { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Idesc { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Iseg { get; set; } = null!;

    [Column("SEGNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string Segnam { get; set; } = null!;
}
