using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("tmpmvg")]
public partial class Tmpmvg
{
    [Column("vsh", TypeName = "decimal(18, 3)")]
    public decimal Vsh { get; set; }

    [Column("vsr", TypeName = "decimal(18, 3)")]
    public decimal Vsr { get; set; }

    [Column("ts", TypeName = "decimal(18, 3)")]
    public decimal Ts { get; set; }

    [Column("BR")]
    public Guid Br { get; set; }

    [Column("IT")]
    public Guid It { get; set; }
}
