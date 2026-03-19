using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class ShoeSize
{
    [StringLength(10)]
    [Unicode(false)]
    public string? Category { get; set; }

    [Column("ShoeSize")]
    public int? ShoeSize1 { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Color { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GroupSize { get; set; }
}
