using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("CUG_List")]
public partial class CugList
{
    [Column("SLNO")]
    public double? Slno { get; set; }

    public double? MobileNo { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    [Column("Area ")]
    [StringLength(255)]
    public string? Area { get; set; }

    [StringLength(255)]
    public string? State { get; set; }

    [StringLength(255)]
    public string? Division { get; set; }

    [StringLength(255)]
    public string? Mode { get; set; }
}
