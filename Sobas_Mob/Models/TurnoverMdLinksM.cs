using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Turnover_MD_Links_M")]
public partial class TurnoverMdLinksM
{
    [StringLength(15)]
    public string RowDisp { get; set; } = null!;

    [Column("LinkUIDs")]
    [StringLength(50)]
    public string LinkUids { get; set; } = null!;

    [StringLength(2)]
    public string LinkType { get; set; } = null!;

    [StringLength(10)]
    public string LinkCodes { get; set; } = null!;

    [StringLength(100)]
    public string? LinkDescription { get; set; }

    [StringLength(3)]
    public string? Disporder { get; set; }
}
