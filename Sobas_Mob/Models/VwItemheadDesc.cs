using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwItemheadDesc
{
    [StringLength(50)]
    [Unicode(false)]
    public string Icode { get; set; } = null!;

    [Column("itemhead")]
    [StringLength(14)]
    [Unicode(false)]
    public string? Itemhead { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Idesc { get; set; } = null!;
}
